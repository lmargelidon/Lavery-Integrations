﻿using System;
using System.Text;
using System.Configuration;
using System.Globalization;
using Lavery.Listeners;
using System.Collections.Generic;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;

using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using Lavery.Schemas;
using Lavery.Schemas.E3;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.Events.Listeners;
using Lavery.Constants;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;





namespace Lavery.Listeners
{
    public class MsSqlTimeCardPendingEvents : ListenerAssiduityBase
    {
        
        ModelToTableMapper<TimeCardPending> mapper;
        String sMutextHost;
        SqlTableDependency<TimeCardPending> dep;       
        jsonSerializer<TimeCardPending> oSerializer = new jsonSerializer<TimeCardPending>();
        String[] aNoBillabeJobTypes;

        public MsSqlTimeCardPendingEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory) 
        {
            try
            {                
                this.oSerializer = new jsonSerializer<TimeCardPending>();                
                this.sMutextHost = OConnectionFactory.getKeyValueString("MutexHost");
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                this.SPrefixeName = SPrefixeName;
                this.mapper = new ModelToTableMapper<TimeCardPending>();
                this.mapper.AddMapping(c => c.TimeCardPendingID, "TimeCardPendingID");
                aNoBillabeJobTypes = OConnectionFactory.getKeyValueString("AssiduiteNoBillableJobTypes").Split(';');
                ODataReferentialManagement.EListenerType = ListenerType.TimeCardPending;
                if (oGuid != default(Guid))
                    OGuidContext = oGuid;
                else
                    OGuidContext = Guid.NewGuid();

            }
            catch (Exception ex)
            {

            }
        }
        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!Disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {                    
                    dep.Dispose();                    
                }

                Disposed = true;
            }
        }
        public Object performTransaction(Object oObjectMessage, String sJson)
        {
            Object oRet = default(Object);
            try
            {
                TimeCardPending oObje = (TimeCardPending)oObjectMessage;
                ODataReferentialManagement.registerLink(oObje.TimeCardPendingID, oObje.TimeStamp, - 1, oObje.refGuid, sJson, oObje.etypeEnvelopp == typeEnvelopp.Delete);
                ODataReferentialManagement.registerRequestProcessed(true,  oObje.TimeCardPendingID);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oRet;
        }
        public override Boolean doInitialize()
        {
            Boolean bRet = true;
            try
            {
                
                using (new SynchronizeGlobalInstance(IWaitOnMutex, OConnectionFactory.getKeyValueString("AssiduiteMutexGlobalValue")))
                {
                    DateTime oLastDT = ODataReferentialManagement.getLastRegisteredDate();

                    if (oLastDT == DateTime.MaxValue)
                    {
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        oLastDT = DateTime.ParseExact(OConnectionFactory.getKeyValueString("AssiduiteTimeCardPendingBaseDate"), "mm/dd/yyyy", provider);
                    }
                    Console.WriteLine("\t\t\tretrieve some notifications from {0} ...", oLastDT);
                    String sJson = ODataReferentialManagement.getAllEntries(oLastDT,  OConnectionSource);
                    JObject data = JObject.Parse(sJson);
                    JArray jArray = (JArray)data.First.First;
                    foreach (JObject item in jArray) 
                    {
                        String sVal = item.ToString();                            
                        TimeCardPending oPending = oSerializer.deserialize(sVal, "dd/MM/yyyy");
                        Guid oGuid = this.ODataReferentialManagement.getLinkCorrelationId(oPending.TimeCardPendingID);
                        if (oGuid != default(Guid))
                        {
                            oPending.etypeEnvelopp = typeEnvelopp.Update;
                            oPending.refGuid = oGuid;
                        }
                        else
                        {
                            oPending.etypeEnvelopp = typeEnvelopp.Insert;
                            oPending.refGuid = Guid.NewGuid();
                        }
                        OStackEnvelopp.push(oPending);
                    }
                    
                }
               
                dep = new SqlTableDependency<TimeCardPending>(OConnectionFactory.ConnectionString("ConnectionSource"), "TimeCardPending", mapper: mapper, includeOldValues: true);
               
                dep.OnChanged += Changed;
                dep.OnError += OnError;
                //dep.OnStatusChanged += OnStatusChanged;

                dep.Start();

                
                Console.WriteLine("\t\t\tWaiting for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(), 
                                                   OConnectionFactory.getKeyValueString("Environment"), 
                                                   "Waiting for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Exception Catch : " + ex.Message,
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }

        public override Boolean doJob()
        {
            Boolean bRet = true;
            try
            {
                //Envelopp<TimeSheet> oEnv = default(Envelopp<TimeSheet>);
                TimeCardPending oTS = default(TimeCardPending);
                if ((oTS = (TimeCardPending)OStackEnvelopp.pop()) != default(TimeCardPending) && oTS.IsNB == 1)
                {
                    try
                    {
                        using (new SynchronizeGlobalInstance(IWaitOnMutex, oTS.TimeCardPendingID.ToString()))//OConnectionFactory.getKeyValueString("AssiduiteMutexGlobalValue")))
                        {

                            if (ODataReferentialManagement.canProcessRequest(true, oTS.TimeCardPendingID))
                            {
                                Console.WriteLine("\t\tTry to Perfom:{0}", oTS.TimeCardPendingID);

                                int iTimeType = getNonBillableTimeType(oTS);


                                if (iTimeType != -1)
                                {
                                    String sMessageOut = oSerializer.serialize(oTS);

                                    performTransaction(oTS, sMessageOut);

                                    Console.WriteLine("\t\tPerfomed:{0}", oTS.TimeCardPendingID);

                                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                          LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                          OConnectionFactory.getKeyValueString("Environment"),
                                                          sMessageOut,
                                                          oTS.refGuid.ToString(), SPrefixeName);
                                }
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                 OConnectionFactory.getKeyValueString("Environment"),
                                                 String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTS), ex.Message),
                                                 oTS.refGuid.ToString(), SPrefixeName);
                        bRet = false;
                    }
                }  
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.PerformEntry.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Terminate for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }
        public override Boolean doTerminate()
        {
            Boolean bRet = true;
            try
            {
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Terminate.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Terminate for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Terminate.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Terminate for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Error?.Message);
            Console.ResetColor();
        }


        private void Changed(object sender, RecordChangedEventArgs<TimeCardPending> e)
        {
            TimeCardPending changedEntity;
            if (e.ChangeType == ChangeType.Insert)
            {
                changedEntity = e.Entity;

                changedEntity = e.Entity;
                changedEntity.etypeEnvelopp = typeEnvelopp.Insert;
                changedEntity.refGuid = Guid.NewGuid();
                OStackEnvelopp.push(changedEntity);
                Console.WriteLine("\t\tInserted:{0}", changedEntity.TimeCardPendingID);
            }
            else
            {
                changedEntity = e.Entity;
                Guid oGuid = this.ODataReferentialManagement.getLinkCorrelationId(changedEntity.TimeCardPendingID);
                if (e.ChangeType == ChangeType.Update)
                {
                    if (e.EntityOldValues != null)
                    {
                        TimeCardPending changedEntityOld = e.EntityOldValues;                        
                    }                    

                    changedEntity.etypeEnvelopp = typeEnvelopp.Update;
                    changedEntity.refGuid = oGuid;
                    OStackEnvelopp.push(changedEntity);
                    Console.WriteLine("\t\tUpdatedted:{0}", changedEntity.TimeCardPendingID);
                }
                else
                if (e.ChangeType == ChangeType.Delete)
                {
                    changedEntity.etypeEnvelopp = typeEnvelopp.Delete;
                    changedEntity.refGuid = oGuid;
                    OStackEnvelopp.push(changedEntity);
                    Console.WriteLine("\t\tDeleted:{0}", changedEntity.TimeCardPendingID);
                }             
            }
        }
       
    }
}
