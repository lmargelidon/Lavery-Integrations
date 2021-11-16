using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LsaInterfaces.WcfServices;
using System.Xml;
using lsaTools.genericEvents;
using LsaEvents.Propagation;
using lsaTools.GenericInterface;
using WcfServiceBaseClass;

namespace WcfEventsHandler
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                 ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfPersistEvents : WcfBaseClass, IWcfPersistEvents//, IWcfClientBase
    {
        genericEventsContainer oContainer = default(genericEventsContainer);



        public WcfPersistEvents()
        {
            try 
            {
                
                oContainer = new genericEventsContainer();
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public String PingService(String sWithCorrelId)
        {
            
            TracePending.Trace(String.Format("Ping received with CorrelId {0}", sWithCorrelId));
            String sRet = getServiceInformation();
            stopActivity();
            return sRet;        

        }
        public void persistEvent(String oDocument, eEventType oEvent) 
        {
            try 
            {
                Guid oGuid = Guid.NewGuid();

                TracePending.Trace(String.Format("Enter {0} in  List {1} Persist Event {2} Document {3}  ", oGuid.ToString(), oContainer.getEventPendingNumber(), oEvent.ToString(), oDocument));
                oContainer.pushEvent(oDocument, oEvent);
                TracePending.Trace(String.Format("Leave {0}",oGuid.ToString()));
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                stopActivity();
            }
        }
        static public void initializeService()
        {
            try
            { }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        static public void cleanUpService()
        {
            try
            { }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
