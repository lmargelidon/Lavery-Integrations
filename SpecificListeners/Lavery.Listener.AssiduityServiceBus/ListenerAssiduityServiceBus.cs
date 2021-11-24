using System;
using System.Text;
using System.Configuration;
using Lavery.Listeners;
using System.Collections.Generic;
using Lavery.Schemas;
using Lavery.Schemas.Legacy;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.Events.Listeners;
using Lavery.Constants;
using Lavery.azure.resources;

namespace Lavery.Listeners
{
    public class ListenerAssiduityServiceBus : ListenerBase
    {
        ServiceRelayServer oRelayServer;
        XMLSerializer<absence_request> oSerializer;
        public ListenerAssiduityServiceBus() : base(default(connectionFactory))
        { 
        }
        public ListenerAssiduityServiceBus(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                OGuidContext = Guid.NewGuid();
                this.oSerializer = new XMLSerializer<absence_request>();
                this.SPrefixeName = SPrefixeName;
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

            
                oRelayServer = new ServiceRelayServer(OConnectionFactory, performTransaction);
                oRelayServer.Open("ConnectionServiceRelay");
                oRelayServer.HybridConnectionName = "AssiduiteServiceRelayHip";
                
                Console.WriteLine("\t\tInitializing listener on Relais : (" + oRelayServer.HybridConnectionName + ")...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the rel;a (naming: " +  oRelayServer.HybridConnectionName + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the relais (naming: " +  oRelayServer.HybridConnectionName + ")...", ex.Message),
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
                absence_request oTS = default(absence_request);

                

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
                oRelayServer.Close(false);
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the relais Stopped (naming: " +  oRelayServer.HybridConnectionName + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the relais (naming: " +  oRelayServer.HybridConnectionName + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }
    }
}
