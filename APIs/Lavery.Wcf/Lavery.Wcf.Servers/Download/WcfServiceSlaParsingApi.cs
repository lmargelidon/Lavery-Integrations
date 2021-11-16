using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceBaseClass;

using System.ServiceModel;
using LsaEvents.Propagation;
using LsaEvent.EventBehavior;
using LsaEventClass;
using DescartesInterfaces;
using DescartesInterfaces.WcfServices;
using System.IO;
using AbstractGenericClasses;
using DescartesLibrary;
using lsaTools.ConfigurationManager;
using LsaAspects;
using System.Threading.Tasks;
using System.Threading;
using LsaTools.StringTools;
using System.Web;
using lsaTools.Runtime;

namespace DescartesRateApi
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfServiceSlaParsingApi : WcfBaseClass, IWcfSlaParsingApi//, IWcfClientBas
    {
        String sEnvironment = "";
        String sDescartesUri = "";
        static Boolean bInitializedFromWindowsService = false;
                       
        public WcfServiceSlaParsingApi()
        {
            try
            {
                TracePending.Trace("WcfServiceSlaParsingApi Object created");
                sEnvironment = System.Configuration.ConfigurationManager.AppSettings["Environment"];
                sDescartesUri = System.Configuration.ConfigurationManager.AppSettings["HttpDescartesEndPoint"];

                persistEventManager.logInformation(LsaBusinessFunctions.eCategory.WcfService, BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement], sEnvironment == null ? "" : sEnvironment, "WcfServiceSlaParsingApi object Instance created Succesfully", Guid.NewGuid().ToString());
            }
            catch
            {
                sEnvironment = "";
            }
            

        }
        static public void initializeService()
        {
            try
            {
                String sEnv = System.Configuration.ConfigurationManager.AppSettings["Environment"];


                persistEventManager.logInformation( LsaBusinessFunctions.eCategory.WcfService, 
                                                    BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement], 
                                                    sEnv == null ? "" : sEnv, "Initialize service Parsing Started", Guid.NewGuid().ToString());
                bInitializedFromWindowsService = true;
                DescartesServicesManager.loadAllServicesBehavior(Guid.NewGuid(), BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement]);
                persistEventManager.logInformation(LsaBusinessFunctions.eCategory.WcfService, BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement], sEnv == null ? "" : sEnv, "Initialize service Parsing Ended", Guid.NewGuid().ToString());
                

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

        

        /*
         *  ----------------------------------------------------------------------------------
         *  Call via hTTPGet
         *  ----------------------------------------------------------------------------------
         */
        public Stream computeRating(string sWithRequest)
        {
            Stream sWithOutDDLStream  = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi];
            Guid oGuid = Guid.NewGuid();
            
            try
            {
                String sRet = "";
                try
                {
                    
                    if (sWithRequest == default(string))
                    {
                        WcfServiceInformation oService = sectionManagement.GetWcfServicesInformation("DescartesRateApi.WcfServiceSlaParsingApi");
                        if (oService != default(WcfServiceInformation))
                            throw (new Exception(string.Format("{0}testParsing?sWithInterfaceName=<InterfaceName>", oService.OUri.AbsoluteUri)));
                    }
                    DescartesServicesManager oMngr = new DescartesServicesManager(Guid.NewGuid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageRequest(oGuid, sBusinessFunction, /*sDescartesUri,*/ sWithRequest);
                }
                catch (Exception ex)
                {
                    sRet = ex.Message;
                }

                byte[] byteArray = Encoding.ASCII.GetBytes(sRet);
                MemoryStream stream = new MemoryStream(byteArray);
                sWithOutDDLStream = stream;
                TracePending.Trace("computeRating invoked...");
            }
            
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }
            return sWithOutDDLStream;
        }
       
        
        /*
         * *************************************************************************************************************************
                expl: http://localhost:8085/testParsing?sWithInterfaceName=TERATHP
         * *************************************************************************************************************************
         */
        /*
        public Stream testParsing(string sWithRequest)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.Test400Parsing];
            Guid oGuid = Guid.NewGuid();

            try
            {
                String sRet = "";
                try
                {
                    if (sWithRequest == default(string))
                    {
                        WcfServiceInformation oService = sectionManagement.GetWcfServicesInformation("DescartesRateApi.WcfServiceSlaParsingApi");
                        if (oService != default(WcfServiceInformation))
                            throw (new Exception(string.Format("{0}testParsing?sWithInterfaceName=<InterfaceName>", oService.OUri.AbsoluteUri)));
                    }
                    DescartesServicesManager oMngr = new DescartesServicesManager(new Guid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageTestRequest(oGuid, sBusinessFunction, eBusinessAction., sWithRequest);
                }
                catch (Exception ex)
                {
                    sRet = ex.Message;
                }

                byte[] byteArray = Encoding.ASCII.GetBytes(sRet);
                MemoryStream stream = new MemoryStream(byteArray);
                sWithOutDDLStream = stream;
                TracePending.Trace("computeRating invoked...");
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message,oGuid.ToString());
            }
            return sWithOutDDLStream;
        }
         * */
        /*
         *  ----------------------------------------------------------------------------------
         *  Call via hTTPPost
         *  ----------------------------------------------------------------------------------
         *  
         */
        public Stream postRating(Stream sWithSourceFactStream)
        {            
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi];
            Guid oGuid = Guid.NewGuid();


            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.ComputeRating, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
        public Stream postcomputeRatingPassThru(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestDecartesCalling];
            Guid oGuid = Guid.NewGuid();

            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestCallDescartes, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
        /*
        public Stream postPingService(Stream sWithCorrelId)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.PingService];
            String sData = "";
            try
            {
                TracePending.Trace(String.Format("Ping received with CorrelId {0}", sWithCorrelId));
                StreamReader sr = new StreamReader(sWithCorrelId, Encoding.UTF8);
                sData = sr.ReadToEnd();
                sData = parseEscapeSequence(sData);

                String sRet = getServiceInformation();
                stopActivity();
                byte[] byteArray = Encoding.ASCII.GetBytes(sRet);
                MemoryStream stream = new MemoryStream(byteArray);
                sWithOutDDLStream = stream;
                TracePending.Trace(String.Format("Ping completed succesfully with CorrelId {0}", sWithCorrelId));
            }

            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, sData);
            }


            return sWithOutDDLStream;

        }
         * */
        /*
        public Stream postRatingArray(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi];
            Guid oGuid = Guid.NewGuid();


            try
            {
                
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.ComputeRating, sWithSourceFactStream, true);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
         * */
        /*
         *  ----------------------------------------------------------------------------------
         *  Call via hTTPPost for Testing
         *  ----------------------------------------------------------------------------------
         */
      
        public Stream postTestToXmlParsingRequest(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.Test400Parsing];
            Guid oGuid = Guid.NewGuid();
           
           
            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestParsingToXmlRequest, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }
           
            return sWithOutDDLStream;
        }
                
        public Stream postTestToXmlParsingResponse(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestXmlParsing];
            Guid oGuid = Guid.NewGuid();


            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestParsingToXmlResponse, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
        public Stream postTestToXmlParsingRequestAndResponse(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestXmlParsing];
            Guid oGuid = Guid.NewGuid();


            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestParsingToXmlRequestAndResponse, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
        public Stream postTestDescartesService(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestDecartesCalling];
            Guid oGuid = Guid.NewGuid();
            
            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestCallDescartes, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }

        
        
        public Stream postTestFromXmlParsing(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestXmlParsing];
            Guid oGuid = Guid.NewGuid();


            try
            {
                sWithOutDDLStream = callDecartesServicesManager(oGuid, sBusinessFunction, eBusinessAction.TestParsingFromXml, sWithSourceFactStream);

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                    sBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oGuid.ToString());
            }

            return sWithOutDDLStream;
        }
        private Stream callDecartesServicesManager(Guid oWithGuid, String sWithBusinessFunction, eBusinessAction eWithTest, Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            
            String sData = "";
            String sRet = "";
            TimingAspect oAspect = TimingAspect.startTimer();
            Boolean bStatus = true;
            try
            {
                TracePending.Trace("Test Infrastructure Invoked: " + sWithBusinessFunction);
                StreamReader sr = new StreamReader(sWithSourceFactStream, Encoding.UTF8);
                sData = sr.ReadToEnd();
                sData = parseEscapeSequence(sData);
                
                try
                {
                    DescartesServicesManager oMngr = new DescartesServicesManager(oWithGuid, BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    switch (eWithTest)
                    {
                        case  eBusinessAction.TestParsingToXmlRequest:
                            sRet = oMngr.parse400(oWithGuid, sWithBusinessFunction, sData);
                            break;
                        case eBusinessAction.TestParsingToXmlResponse:
                            sRet = oMngr.parse400(oWithGuid, sWithBusinessFunction, sData);
                            sRet = oMngr.propageTestRequest(oWithGuid, sWithBusinessFunction, sDescartesUri, sRet);
                            break;
                        case eBusinessAction.TestParsingToXmlRequestAndResponse:
                            String sRet1 = oMngr.parse400(oWithGuid, sWithBusinessFunction, sData);
                            sRet = sRet1 + "\n/**/\n" + oMngr.propageTestRequest(oWithGuid, sWithBusinessFunction, sDescartesUri, sRet1);

                            break;
                        case eBusinessAction.TestParsingFromXml:
                            sRet = oMngr.parseXml(oWithGuid, sWithBusinessFunction, sData);
                            break;
                        case eBusinessAction.TestCallDescartes:
                            sRet = oMngr.propageTestRequest(oWithGuid, sWithBusinessFunction, sDescartesUri, sData);
                            break;
                        case eBusinessAction.ComputeRating:
                            try
                            {
                                TimingAspect oAspect1 = TimingAspect.startTimer();
                                /*String[] sSep = { eMessageEnum.TERATHP.ToString() };
                                String[] aMessage = sData.Split(sSep, StringSplitOptions.RemoveEmptyEntries);
                                 * */
                                List<LsaTools.StringTools.cPair> aMessage = StringParsing.Split(sData, DescartesConstantes.aMessageGroup, eSplitOption.None);
                                int iMaxVal = 1;
                                if (aMessage.Count > 1)
                                {
                                    Object oSync = new object();
                                    List<String> lReturnedValue = new List<string>();
                                    iMaxVal = aMessage.Count;
                                    int iParalleleThread = 0;
                                    /*
                                    Parallel.ForEach(aMessage, new ParallelOptions { MaxDegreeOfParallelism = -1 }, sItem =>
                                        {
                                            try
                                            {
                                                sRet = oMngr.propageRequest(oWithGuid, sWithBusinessFunction, eMessageEnum.TERATHP.ToString() + sItem);
                                                lock (oSync)
                                                    lReturnedValue.Add(sRet);
                                            }
                                            catch (Exception ex)
                                            {
                                                TracePending.Trace(ex.Message);
                                                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                                                    sWithBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oWithGuid.ToString());
                                            }
                                        }
                                        );
                                    */
                                    List<Task> lTask = new List<Task>();
                                    TracePending.Trace("Before Parallele");
                                    foreach (cPair oItem in aMessage)
                                    {
                                        var taskA = new Task(() =>
                                        {
                                            try
                                            {
                                                lock (oSync)
                                                {
                                                    iParalleleThread++;
                                                }
                                                sRet = oMngr.propageRequest(oWithGuid, sWithBusinessFunction, oItem.sValue);
                                                lock (oSync)
                                                {
                                                    lReturnedValue.Add(sRet);
                                                    TracePending.Trace(String.Format("Thread in Parallel {0}", iParalleleThread--));
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                TracePending.Trace(ex.Message);
                                                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService,
                                                    sWithBusinessFunction, sEnvironment == null ? "" : sEnvironment, ex.Message, oWithGuid.ToString());
                                            }
                                        }, TaskCreationOptions.LongRunning);
                                        lTask.Add(taskA);
                                        taskA.Start();
                                    }
                                    Task.WaitAll(lTask.ToArray());

                                   /*
                                    while (lReturnedValue.Count < aMessage.Length)
                                        Thread.Sleep(100);
                                    * */
                                    sRet = "";
                                    foreach (String sItem in lReturnedValue)
                                        sRet += sItem;
                                }
                                else
                                    sRet = oMngr.propageRequest(oWithGuid, sWithBusinessFunction, /*sDescartesUri,*/ sData);
                                if(!bInitializedFromWindowsService)
                                    Console.WriteLine(String.Format("Propage <{0}> Descartes Request{1} in <{2}>milliseconds", iMaxVal, iMaxVal==1?"":"s", oAspect1.stop()));
                            }
                            catch (Exception ex)
                            {
                                throw (ex);
                            }
                            break;
                    }                                      
                    
                }
                catch (Exception ex)
                {
                    sRet = ex.Message;
                    bStatus = false;
                }


                byte[] byteArray = Encoding.ASCII.GetBytes(sRet);
                MemoryStream stream = new MemoryStream(byteArray);
                sWithOutDDLStream = stream;
                TracePending.Trace("Test Infrastructure ended Successfully: " + sWithBusinessFunction);

            }
            catch (Exception ex)
            {
                bStatus = false;
                throw (ex);

            }
            finally
            {
                persistEventManager.logStatistic(LsaBusinessFunctions.eCategory.WcfService, sWithBusinessFunction, sEnvironment, sData.Length, sRet.Length, (int)oAspect.stop(), oWithGuid.ToString(), bStatus);

            }
            return sWithOutDDLStream;
        }
        String parseEscapeSequence(String sBuffer)
        {
            String sData = sBuffer;
            try 
            {
                sData = Uri.UnescapeDataString(sData);
                sData = sData.Replace("+", "_PLus_");
                sData = Encoding.UTF7.GetString(HttpUtility.UrlDecodeToBytes(sData));
                sData = sData.Replace("_PLus_", "+");
            }
            catch { }
            return sData;
        }
        public String PingService(String sWithCorrelId)
        {
            String sRet = "";
            try
            {
                TracePending.Trace(String.Format("Ping received with CorrelId {0}", sWithCorrelId));
                sRet = getServiceInformation();
                stopActivity();
            }
            catch
            {}
            return sRet;
        }
        
    }
}
