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
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;


namespace Lavery.Wcf.Api.E3
{
   
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfApiToE3 : WcfBaseClass, IE3Api//, IWcfClientBas
    {        
        connectionFactory OCF;
        ClientApiFacade oFacadeClient;
        MatterApiFacade oFacadeMatter;
        String sPrefix;
        Guid oGuid;

        public WcfApiToE3()
        {
            try
            {
                OCF = new connectionFactory();
                oFacadeClient = new ClientApiFacade(OCF);
                oFacadeMatter = new MatterApiFacade(OCF);
                oGuid = Guid.NewGuid();
                sPrefix = "WcfServer";

                //TracePending.Trace("WcfServiceSlaDispatchRequest Object created");
            }
            catch
            {
               
            }
            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                OCF.getKeyValueString("Environment"), "WcfServiceSlaParsingApi object Instance created Succesfully", oGuid.ToString());

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
         * ********************************************************************************
         */
        
        public genericResponse postListOfMatter(MattersGet data)
        {
            genericResponse oRet = new genericResponse();
            try
            {

                if (data != default(MattersGet))
                {
                    MatterGetMattersRequest dataE3 = new MatterGetMattersRequest();

                    dataE3.matterId = data.matterId;
                    dataE3.mattIndex = data.mattIndex;
                    dataE3.number = data.number;
                    dataE3.advancedFilterChildObjectsToInclude = null;
                    dataE3.advancedFilterAttributesToInclude = null;
                    dataE3.advancedFilterFilterXOQL = null;
                    dataE3.advancedFilterFilterPredicates = null;
                    dataE3.advancedFilterFilterOperator = null;
                    dataE3.advancedFilterFilterGroups = null;
                    dataE3.x3ESessionId = null;
                    dataE3.x3EUserId = null;
                    dataE3.acceptLanguage = null;
                    E3EAPIMatterModelsMatterGetResponse oRetE3 = default(E3EAPIMatterModelsMatterGetResponse);
                    Console.WriteLine("\t\t\tListener Wcf to E3 called ...");
                    oRetE3 = oFacadeMatter.MatterGetMatters(dataE3);                    
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                       OCF.getKeyValueString("Environment"),
                                                       "Call E3 MatterGetMatters()...",
                                                       oGuid.ToString(), sPrefix);

                    
                    oRet.Attributes = new Dictionary<string, KeyValuePair<String, Type>>();

                    foreach (E3EAPIMatterModelsMatter oElt in oRetE3.Matters)
                    {
                        foreach (KeyValuePair<String,E3EAPIDataModelsAttribute> pair in oElt.Attributes)
                        {
                            Console.WriteLine("{2} {0} = {1}",pair.Key, pair.Value.Value, pair.Value.DataType);
                            //oRet.Attributes.Add(pair.Key, new KeyValuePair<String, Type>(pair.Value.Value, pair.Value.DataType.GetType()));
                            
                        }
                    }
                    oRet.Success = oRetE3.Success;
                    oRet.Message = oRetE3.Message;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\t\tCall E3 MatterGetMatters()->Exception Thrown : {0}", ex.Message);
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OCF.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the Wcf to E3...", ex.Message),
                                                   oGuid.ToString(), sPrefix);
                oRet.Success = false;
                oRet.Message = ex.Message;
            }
            return oRet;
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
