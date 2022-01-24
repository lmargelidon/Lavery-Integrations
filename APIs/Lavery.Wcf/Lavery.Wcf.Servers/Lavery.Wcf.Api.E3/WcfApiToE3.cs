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


using Lavery.Wcf.Core;


namespace Lavery.Wcf.Api.E3
{
   
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class WcfApiToE3 :  IE3Api//, IE3MatterApi//,WcfBaseClass
    {        
        connectionFactory oCF;
        ClientApiFacade oFacadeClient;
        //MatterApiFacade oFacadeMatter;
        List<WcfBaseApi> lOfApis = new List<WcfBaseApi>();
        String sPrefix;
        Guid oGuid;

        public connectionFactory OCF { get => oCF;  }

        public WcfApiToE3()
        {
            try
            {
                oCF = new connectionFactory();
                oFacadeClient = new ClientApiFacade(OCF);
                //oFacadeMatter = new MatterApiFacade(OCF);
                oGuid = Guid.NewGuid();
                sPrefix = "WcfServer";
                initializeApis();

                //TracePending.Trace("WcfServiceSlaDispatchRequest Object created");
            }
            catch
            {
               
            }
            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                OCF.getKeyValueString("Environment"), "WcfServiceSlaParsingApi object Instance created Succesfully", oGuid.ToString());

        }
        void initializeApis()
        {
            try
            {

                lOfApis.Add(new WcfApiMattersToE3(oCF, sPrefix, oGuid));

            }
            catch (Exception ex)
            {
                throw (ex);
            }
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
        WcfBaseApi getApi(Type oType)
        {       
            return lOfApis.Find(x => x.GetType() == oType); ;
        }


        public String postExistClient(ClientGetClientsRequest data)
        {
            String sRet = "false";
            try
            {

                if (data != default(ClientGetClientsRequest))
                {
                    E3EAPIClientModelsClientGetResponse oResponse1 = oFacadeClient.ClientGetClients( data);
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
                    E3EAPIClientModelsClientGetResponse oResponse1 = oFacadeClient.ClientGetClients(oData);

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
        /*
         * ********************************************************************************
         * Matters
         * ********************************************************************************
         */
        public MattersGetResponse postListOfMatter(MatterGetMattersRequest data)
        {
            MattersGetResponse oRet;
            WcfApiMattersToE3 oApi = (WcfApiMattersToE3)getApi(typeof(WcfApiMattersToE3));
            if (oApi == default(WcfApiMattersToE3))
            { 
                oRet = new MattersGetResponse();
            }
            else
                oRet = oApi.postListOfMatter(data);
            return oRet;
        }
      
        public String postEcho()
        {
            return "Echo from service";
        }
        
    }
}
