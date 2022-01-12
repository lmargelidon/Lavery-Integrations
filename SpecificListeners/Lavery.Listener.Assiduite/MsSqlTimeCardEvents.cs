using System;
using System.Text;
using System.Configuration;
using Lavery.Listeners;
using System.Collections.Generic;
using System.Globalization;
using System.Data.SqlClient;
using System.Transactions;
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
using Lavery.Connector;
using Newtonsoft.Json.Linq;





namespace Lavery.Listeners
{
    public class MsSqlTimeCardEvents : ListenerAssiduityBase
    {
        
        ModelToTableMapper<TimeCard> mapper;
        String sMutextHost;
        SqlTableDependency<TimeCard> dep;       
        jsonSerializer<TimeCard> oSerializer = new jsonSerializer<TimeCard>();
        MsMq<TimeCard> oMq;
        String[] aNoBillabeJobTypes;
        


        public MsSqlTimeCardEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory) 
        {
            try
            {
                
                this.oSerializer = new jsonSerializer<TimeCard>();                
                this.sMutextHost = OConnectionFactory.getKeyValueString("MutexHost");
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                this.SPrefixeName = SPrefixeName;
                this.mapper = new ModelToTableMapper<TimeCard>();
                this.mapper.AddMapping(c => c.TimecardID, "TimeCardID");
                aNoBillabeJobTypes = OConnectionFactory.getKeyValueString("AssiduiteNoBillableJobTypes").Split(';');
                ODataReferentialManagement.EListenerType = ListenerType.TimeCard; 


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
        public Boolean performTransaction(Object oObjectMessage, String sJson)
        {
            Boolean bRet = true;
            try
            {

                TimeCard oObje = (TimeCard)oObjectMessage;
                ODataReferentialManagement.registerLink(oObje.TimecardID, oObje.TimeStamp, -1, oObje.refGuid, sJson, oObje.etypeEnvelopp == typeEnvelopp.Delete);
                ODataReferentialManagement.registerRequestProcessed(true, oObje.TimecardID);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
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
                        oLastDT = DateTime.ParseExact(OConnectionFactory.getKeyValueString("AssiduiteTimeCardBaseDate"), "mm/dd/yyyy", provider);
                    }
                    Console.WriteLine("\t\t\tretrieve some notifications from {0} ...", oLastDT);
                    String sJson = ODataReferentialManagement.getAllEntries(oLastDT,  OConnectionSource);
                    JObject data = JObject.Parse(sJson);
                    JArray jArray = (JArray)data.First.First;
                    foreach (JObject item in jArray)
                    {
                        String sVal = item.ToString();
                        TimeCard oPending = oSerializer.deserialize(sVal, "dd/MM/yyyy");
                        Guid oGuid = this.ODataReferentialManagement.getLinkCorrelationId(oPending.TimecardID);
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
                
                oMq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateQueue");

                dep = new SqlTableDependency<TimeCard>(OConnectionFactory.ConnectionString("ConnectionSource"), "TimeCard", mapper: mapper, includeOldValues: true);
               
                dep.OnChanged += Changed;
                dep.OnError += OnError;
                //dep.OnStatusChanged += OnStatusChanged;

                dep.Start();

                isInitialized = true;
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
                TimeCard oTS = default(TimeCard);
                if ((oTS = (TimeCard)OStackEnvelopp.pop()) != default(TimeCard) )
                {
                    try
                    {
                        using (new SynchronizeGlobalInstance(IWaitOnMutex, oTS.TimecardID.ToString()))//OConnectionFactory.getKeyValueString("AssiduiteMutexGlobalValue")))
                        {


                            if (ODataReferentialManagement.canProcessRequest(true, oTS.TimecardID))
                            {
                                                                

                                int iTimeType = getNonBillableTimeType(oTS);

                                if (iTimeType != -1)
                                {                                    
                                    String sMessageOut = oSerializer.serialize(oTS);
                                    // oMq.send(performTransaction, sMessageOut, oTS);
                                    int iId = ODataReferentialManagement.getLinkPrimaryKeyValue(oTS.TimecardID);
                                    if (iId == default(int) && oTS.etypeEnvelopp == typeEnvelopp.Insert || 
                                        iId != default(int) && oTS.etypeEnvelopp != typeEnvelopp.Insert)
                                    {
                                        try
                                        {
                                            using (TransactionScope scope = new TransactionScope())
                                            {
                                                using (SqlConnection oConnectionReferentialTrx = new SqlConnection(OConnectionFactory.ConnectionString("ConnectionReferential")))
                                                using (MsMq<TimeCard> oMsMq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateQueue", true, true))
                                                {
                                                    oConnectionReferentialTrx.Open();
                                                    oMsMq.send(sMessageOut, oTS);
                                                    ODataReferentialManagement.registerLink(oTS.TimecardID, oTS.TimeStamp, -1, oTS.refGuid, sMessageOut, oTS.etypeEnvelopp == typeEnvelopp.Delete, oConnectionReferentialTrx);
                                                    ODataReferentialManagement.registerRequestProcessed(true, oTS.TimecardID, oConnectionReferentialTrx);
                                                    /*
                                                        if (BAleatoirExceptionGeneration)
                                                            if(ORandomException.Next(10) > 5)
                                                                throw (new Exception("Aleatoire exception generated..."));
                                                    */
                                                }
                                                scope.Complete();
                                            }
                                            persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                                        LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                                        OConnectionFactory.getKeyValueString("Environment"),
                                                                        sMessageOut,
                                                                        oTS.refGuid.ToString(), SPrefixeName);
                                        }
                                        catch (Exception ex)
                                        {
                                            using (TransactionScope scope = new TransactionScope())
                                            {
                                                using (SqlConnection oConnectionReferentialTrx = new SqlConnection(OConnectionFactory.ConnectionString("ConnectionReferential")))
                                                using (MsMq<TimeCard> oMsMqDlq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateDLQWrite", true, true))
                                                {
                                                    /*
                                                     * Enrtegistreer5 dans une DLQ pour traitement ulterieur
                                                     * ne pas oublier d'enregistrer 
                                                     */
                                                    oConnectionReferentialTrx.Open();
                                                    ODataReferentialManagement.registerRequestProcessed(true, oTS.TimecardID, oConnectionReferentialTrx);
                                                    oMsMqDlq.send(sMessageOut, oTS);                                                   

                                                }
                                                scope.Complete();
                                            }
                                            persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                OConnectionFactory.getKeyValueString("Environment"),
                                                String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTS), ex.Message),
                                                oTS.refGuid.ToString(), SPrefixeName);
                                            bRet = false;
                                        }

                                    }

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


        private void Changed(object sender, RecordChangedEventArgs<TimeCard> e)
        {



            TimeCard oTS = new TimeCard();
            if (e.ChangeType == ChangeType.Insert)
            {
                TimeCard changedEntity = e.Entity;

                oTS = changedEntity;                
                oTS.etypeEnvelopp = typeEnvelopp.Insert;
                oTS.refGuid = Guid.NewGuid();
                OStackEnvelopp.push(oTS);
            }
            else
            {
                TimeCard changedEntity = e.Entity;
                Guid oGuid = this.ODataReferentialManagement.getLinkCorrelationId(changedEntity.TimecardID);
                if (e.ChangeType == ChangeType.Update)
                {
                    if (e.EntityOldValues != null)
                    {
                        TimeCard changedEntityOld = e.EntityOldValues;                        
                    }
                    

                    changedEntity.etypeEnvelopp = typeEnvelopp.Update;
                    changedEntity.refGuid = oGuid;
                    OStackEnvelopp.push(changedEntity);
                }
                else
                if (e.ChangeType == ChangeType.Delete)
                {
                    changedEntity.etypeEnvelopp = typeEnvelopp.Delete;
                    changedEntity.refGuid = oGuid;
                    OStackEnvelopp.push(changedEntity);
                }             
            }
        }
       
    }
}
