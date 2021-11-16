using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Tools.Runtime;
using Lavery.Client.E3;
using Org.OpenAPITools.Model;



namespace Lavery.Wcf.Api.E3
{
   
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfApiToE3 : WcfBaseClass, IE3Api//, IWcfClientBas
    {
        String sEnvironment = "";
        connectionFactory OCF;
        ClientApiFacade oFacade;

        public WcfApiToE3()
        {
            try
            {
                OCF = new connectionFactory();
                oFacade = new ClientApiFacade(new connectionFactory());

                TracePending.Trace("WcfServiceSlaDispatchRequest Object created");
            }
            catch
            {
                sEnvironment = "";
            }
            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                OCF.getKeyValueString("Environment"), "WcfServiceSlaParsingApi object Instance created Succesfully", Guid.NewGuid().ToString());

        }
        static public void initializeService()
        {
            try
            {

                

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        static public void cleanUpService()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        
        public String postExistClient(ClientGetClientsRequest data)
        {
            String sRet = "false";
            try
            {

                if (data != default(ClientGetClientsRequest))
                {
                    E3EAPIClientModelsClientGetResponse oResponse1 = oFacade.ClientGetClients( data);
                    if (oResponse1.Clients.Count > 0)
                        sRet = "true";
                }
            }
            catch (Exception ex)
            { }
            return sRet;
        }
        
        public String getClient(String data)
        {
            String sRet = "false";
            try
            {
                if (data != default(String))
                {
                    
                    ClientGetClientsRequest oData;
                    try
                    {
                        jsonSerializer<ClientGetClientsRequest> oSerial = new jsonSerializer<ClientGetClientsRequest>();
                        oData = oSerial.deserialize(data);
                    }
                    catch (Exception)
                    {
                        oData = new ClientGetClientsRequest() { number  = data };
                    }
                    E3EAPIClientModelsClientGetResponse oResponse1 = oFacade.ClientGetClients(oData);

                    if (oResponse1.Clients.Count > 0)
                    {
                        sRet = oResponse1.Clients[0].ToJson();
                        sRet = sRet.Replace("\\", "").Replace("\r\n", "");
                    }
                    
                }

            }
            catch (Exception ex)
            { }
            return sRet;
        }
        public String postEcho()
        {
            return "Echo from service";
        }
        public String PingService(String sWithCorrelId)
        {

            TracePending.Trace(String.Format("Ping received with CorrelId {0}", sWithCorrelId));
            String sRet = getServiceInformation();
            stopActivity();
            return sRet;

        }
    }
}
