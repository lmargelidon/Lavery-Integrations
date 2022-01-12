using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.Events.Listeners;
using Lavery.Constants;
using Lavery.Wcf.Api.E3;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using Lavery.Listeners;


namespace Lavery.Listeners
{ 
    public class ListenerWcfE3 : ListenerBase
    {
        ServiceHost wcfServiceApi;

        public ListenerWcfE3(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                OGuidContext = Guid.NewGuid();                
                this.SPrefixeName = SPrefixeName;
                ODataReferentialManagement.EListenerType = ListenerType.Wcf;
                if (oGuid != default(Guid))
                    OGuidContext = oGuid;
                else
                    OGuidContext = Guid.NewGuid();
            }
            catch (Exception ex)
            {

            }
        }

        public Boolean performTransaction(Object oObjectMessage)
        {
            Boolean bRet = true;
            try
            {
                

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
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
                WcfApiToE3.initializeService();
                
                wcfServiceApi = new WebServiceHost(typeof(WcfApiToE3));
                ServiceEndpoint ep = wcfServiceApi.AddServiceEndpoint(typeof(IE3Api), new WebHttpBinding(), "");
                ServiceDebugBehavior stp = wcfServiceApi.Description.Behaviors.Find<ServiceDebugBehavior>();
                stp.HttpHelpPageEnabled = false;
                wcfServiceApi.Open();


                Console.WriteLine("\t\t\tInitializing listener on Wcf to E3 ...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the Wcf to E3 ...",
                                                   OGuidContext.ToString(), SPrefixeName);
                isInitialized = true;
            }
            catch (Exception ex)
            {               
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the Wcf to E3...", ex.Message),
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

                WcfApiToE3.cleanUpService();
                wcfServiceApi.Close();
                wcfServiceApi = null;


                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the Wcf to E3 Stopped ...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the Wcf to E3...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }
    }
}
