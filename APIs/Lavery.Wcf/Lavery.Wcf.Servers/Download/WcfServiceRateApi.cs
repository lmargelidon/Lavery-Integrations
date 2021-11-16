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

namespace DescartesRateApi
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfServiceRateApi : WcfBaseClass, IWcfDescartesRateApi//, IWcfClientBas
    {
        String sEnvironment = "";
               
        public WcfServiceRateApi()
        {
            try
            {
                TracePending.Trace("WcfServiceRateApi Object created");
                sEnvironment = System.Configuration.ConfigurationManager.AppSettings["Environment"];
                
                
            }
            catch
            {
                sEnvironment = "";
            }
            persistEventManager.logInformation(LsaBusinessFunctions.eCategory.WcfService, BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement], sEnvironment == null ? "" : sEnvironment, "WcfServiceRateApi object Instance created Succesfully", Guid.NewGuid().ToString());

        }
        static public void initializeService()
        {
            try
            {

                DescartesServicesManager.loadAllServicesBehavior(Guid.NewGuid(), BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement]);

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
        public responseData computeRating(requestData sWithSourceFactStream)
        {
            responseData sWithOutDDLStream = new responseData();
            try
            {
                sWithOutDDLStream.detail = "retourne une valeur";
                TracePending.Trace("genereBrmsDataModel invoked...");
                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                persistEventManager.logError(LsaBusinessFunctions.eCategory.WcfService, LsaBusinessFunctions.oBusinessFunction[LsaBusinessFunctions.eBusinessFunction.PlayTestCases], sEnvironment == null ? "" : sEnvironment, ex.Message,sGuid);
            }
            return sWithOutDDLStream;
        }
 * */
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
                        WcfServiceInformation oService = sectionManagement.GetWcfServicesInformation("DescartesRateApi.WcfServiceRateApi");
                        if (oService != default(WcfServiceInformation))
                            throw (new Exception(string.Format("{0}testParsing?sWithInterfaceName=<InterfaceName>", oService.OUri.AbsoluteUri)));
                    }
                    DescartesServicesManager oMngr = new DescartesServicesManager(Guid.NewGuid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageRequest(oGuid, sBusinessFunction, sWithRequest);
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
        public Stream testParsing(string sWithRequest)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestRateApi];
            Guid oGuid = Guid.NewGuid();

            try
            {
                String sRet = "";
                try
                {
                    if (sWithRequest == default(string))
                    {
                        WcfServiceInformation oService = sectionManagement.GetWcfServicesInformation("DescartesRateApi.WcfServiceRateApi");
                        if (oService != default(WcfServiceInformation))
                            throw (new Exception(string.Format("{0}testParsing?sWithInterfaceName=<InterfaceName>", oService.OUri.AbsoluteUri)));
                    }
                    DescartesServicesManager oMngr = new DescartesServicesManager(new Guid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageTestRequest(oGuid, sBusinessFunction, eBusinessTest.Parsing, sWithRequest);
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
        /*
         *  ----------------------------------------------------------------------------------
         *  Call via hTTPPost
         *  ----------------------------------------------------------------------------------
         */
        public Stream postRating(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi];
            Guid oGuid = Guid.NewGuid();
            
            try
            {
                String sRet = "";
                StreamReader sr = new StreamReader(sWithSourceFactStream);
                String sData = sr.ReadToEnd();
                try
                {
                    DescartesServicesManager oMngr = new DescartesServicesManager(new Guid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageRequest(oGuid, sBusinessFunction, sData);
                }
                catch (Exception ex)
                {
                    sRet = ex.Message;
                }
                
                String sRetData = "Retourne la chaine:" ; //invoke DEscartes API
                byte[] byteArray = Encoding.ASCII.GetBytes(sRetData);
                MemoryStream stream = new MemoryStream( byteArray ); 
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

        public Stream postTestParsing(Stream sWithSourceFactStream)
        {
            Stream sWithOutDDLStream = default(Stream);
            String sBusinessFunction = BusinessInformation.oBusinessFunction[eBusinessFunction.TestRateApi];
            Guid oGuid = Guid.NewGuid();

            try
            {
                String sRet = "";
                StreamReader sr = new StreamReader(sWithSourceFactStream);
                String sData = sr.ReadToEnd();
                try
                {
                    DescartesServicesManager oMngr = new DescartesServicesManager(new Guid(), BusinessInformation.oBusinessFunction[eBusinessFunction.ComputeRateApi]);
                    sRet = oMngr.propageTestRequest(oGuid, sBusinessFunction, eBusinessTest.Parsing, sData);
                }
                catch (Exception ex)
                {
                    sRet = ex.Message;
                }

                String sRetData = "Retourne la chaine:" + sData; 
                byte[] byteArray = Encoding.ASCII.GetBytes(sRetData);
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
       
        public String PingService(String sWithCorrelId)
        {

            TracePending.Trace(String.Format("Ping received with CorrelId {0}", sWithCorrelId));
            String sRet = getServiceInformation();
            stopActivity();
            return sRet;

        }
    }
}
