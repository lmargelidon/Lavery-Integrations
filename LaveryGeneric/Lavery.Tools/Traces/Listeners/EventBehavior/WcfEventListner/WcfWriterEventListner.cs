using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Collections;
/*
using WCFServices.Clients;
using Lavery.Events;

using Lavery.Tools.genericEvents;
using Lsa.Tools.XML;
using Lavery.Events.Listeners; 
using Lavery.Tools.Runtime;  

namespace Lavery.Events.Listeners
{
    class WcfWriterEventListner : baseWriterTraceListener
    {

        persistEventSender oWcfSerializer = default(persistEventSender);
        
        

        public WcfWriterEventListner(string sWithServiceModelEntry)
        {
            try
            {
                
                oWcfSerializer = new persistEventSender(sWithServiceModelEntry);


                Open();
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        protected void Open()
        {
            try
            {
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
        }


        public override void TraceEvent(LogEventEntry oWithEvent)
        {
            try
            {
                lock (syncObject)
                {
                    TracePending.Trace("Dans WCF TraceLIstener TraceEvent");
                    String sSerializedData = SerializeMessage.serialize(oWithEvent);
                    eEventType eType = eEventType.Log;

                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    oWcfSerializer.propageEvent(sSerializedData, eType);
                    TracePending.Trace("A la fin de WCF TraceLIstener TraceEvent");
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }

        }
        public override void TraceEvent(AuditEventEntry oWithEvent)
        {
            try
            {
                lock (syncObject)
                {


                    String sSerializedData = SerializeMessage.serialize(oWithEvent);
                    eEventType eType = eEventType.Audit;

                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    oWcfSerializer.propageEvent(sSerializedData, eType);
                    TracePending.Trace("A la fin de WCF TraceLIstener TraceEvent");
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }

        }
        public override void TraceEvent(StatisticEventEntry oWithEvent)
        {
            try
            {
                lock (syncObject)
                {
                    TracePending.Trace("Dans WCF TraceLIstener TraceEvent");
                    String sSerializedData = SerializeMessage.serialize(oWithEvent);
                    eEventType eType = eEventType.Statistic;

                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    oWcfSerializer.propageEvent(sSerializedData, eType);
                    TracePending.Trace("A la fin de WCF TraceLIstener TraceEvent");
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }

        }
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params Object[] data)
        {
            try
            {

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        
        protected override String[] GetSupportedAttributes()
        {
            return new string[] { "SChema", "source" };
            
        }
    }

}
*/