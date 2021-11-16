using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Client.E3;
using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Model;
using Lavery.Listeners;
using Lavery.Schemas.Legacy;
using Lavery.Schemas;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Events.Listeners;
using System.Data;
using System.Data.SqlClient;

namespace Lavery.Listeners
{
    public class ListenerAssiduityServingAccess : ListenerAssiduityBase
    {
        TimeApiFacade oFacade;
        String sMutextHost;               
        XMLSerializer<absence_request> oSerializer;
        Boolean Disposed;

        public ListenerAssiduityServingAccess(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            /*
            oFacade = new TimeApiFacade(oConnectionFactory);
            TimeGetPendingTimecardsRequest oParam = new TimeGetPendingTimecardsRequest() { startDate = new DateTime(2021, 11, 7), timekeeperNumber = "1014" };
            E3EAPITimeModelsTimecardGetResponse oResponse = oFacade.TimeGetPendingTimecards(oParam);
            */
            this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
            OGuidContext = Guid.NewGuid();
            this.oSerializer = new XMLSerializer<absence_request>();
            this.SPrefixeName = SPrefixeName;
            if (oGuid != default(Guid))
                OGuidContext = oGuid;
            else
                OGuidContext = Guid.NewGuid();
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
                   
                }

                Disposed = true;
            }
        }
        public override Boolean doInitialize()
        {
            Boolean bRet = true;
            try
            {

                oFacade = new TimeApiFacade(OConnectionFactory);
                Console.WriteLine("\t\t\tInitializing listener via E3 TimeApi : (TimeCard pulling)...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen via E3 TimeApi (naming: TimeCard pulling)...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "via E3 TimeApi (naming:TimeCard pulling)...", ex.Message),
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
                TimeGetPendingTimecardsRequest oParam = new TimeGetPendingTimecardsRequest() { startDate = new DateTime(2019, 1, 1), timekeeperNumber = "1014" };
                E3EAPITimeModelsTimecardGetResponse oResponse = oFacade.TimeGetPendingTimecards(oParam);
                
                absence_request oObjectMessage = default(absence_request);
                foreach (E3EAPITimeModelsTimecard OTC in oResponse.Timecards)
                {
                    using (new SynchronizeGlobalInstance(IWaitOnMutex, OTC.Id))
                    {
                        String sVal = OTC.Attributes["LoadGroup"].Value;
                        sVal = sVal.Replace("><", "__");
                        sVal = sVal.Replace(">", "");
                        sVal = sVal.Replace("<", "");
                        String[] aGroup = sVal.Split('_');
                        foreach (KeyValuePair<String, E3EAPIDataModelsAttribute> Attrib in OTC.Attributes)
                            Console.WriteLine("DataType:{0} Alias {1}  Value {2}", Attrib.Value.DataType, Attrib.Key, Attrib.Value.Value);
                        oObjectMessage = new absence_request()
                        {
                            id_origine = OTC.Attributes["ItemID"].Value,
                            nb_hours = OTC.Attributes["TimeType"].Value.Equals("Hourly") ? decimal.Parse(OTC.Attributes["WorkHrs"].Value) : 0,
                            userIdString = aGroup[0],
                            comment = OTC.Attributes["Narrative"].Value
                        };
                        /*
                            *Voir la synchronization absence_request_id.....
                            
                        if (ODataReferentialManagement.canProcessRequest(true, "TableTimeSheetEvents", oObjectMessage.id_origine))
                        {
                            switch (oObjectMessage.etypeEnvelopp)
                            {
                                case typeEnvelopp.Insert:
                                    insertAssiduity(oObjectMessage);
                                    break;
                                case typeEnvelopp.Update:
                                    updatetAssiduity(oObjectMessage);
                                    break;
                                case typeEnvelopp.Delete:
                                    deleteAssiduity(oObjectMessage);
                                    break;
                                default:
                                    break;
                            }

                        }   
                        */
                    }
                }


            }
            catch (Exception ex)
            {
                bRet = false;
            }
            return bRet;
        }
        public override Boolean doTerminate()
        {
            Boolean bRet = true;
            try
            {
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen via E3 TimeApi Stopped (naming:  TimeCard pulling)...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen via E3 TimeApi (naming:  TimeCard pulling)...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }

        

    }
}
