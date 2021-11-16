using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WcfServiceBaseClass;
using DescartesInterfaces.WcfServices;
using LsaEvents.Propagation;
using LsaEvent.EventBehavior;
using LsaEventClass;
using AbstractGenericClasses;
using DescartesInterfaces;
using lsaTools.Runtime;

namespace DescartesDispatchRequests
{
   
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                  ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfServiceSlaDispatchRequest : WcfBaseClass, iWcfSlaDispatchingApi//, IWcfClientBas
    {
        String sEnvironment = "";

        public WcfServiceSlaDispatchRequest()
        {
            try
            {
                TracePending.Trace("WcfServiceSlaDispatchRequest Object created");
                sEnvironment = System.Configuration.ConfigurationManager.AppSettings["Environment"];


            }
            catch
            {
                sEnvironment = "";
            }
            persistEventManager.logInformation(LsaBusinessFunctions.eCategory.WcfService, BusinessInformation.oBusinessFunction[eBusinessFunction.InfrastructureManagement], sEnvironment == null ? "" : sEnvironment, "WcfServiceSlaParsingApi object Instance created Succesfully", Guid.NewGuid().ToString());

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

        public String dispatchRequest(String sWithRequest)
        {
            String sRet = "";
            try
            { 

            
            }
            catch (Exception ex)
            { }
            return sRet;
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
