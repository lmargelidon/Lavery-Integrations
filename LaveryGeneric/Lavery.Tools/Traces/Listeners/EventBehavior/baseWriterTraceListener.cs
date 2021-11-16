using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using Lavery.Tools.Runtime;


namespace Lavery.Events.Listeners
{
    public class baseWriterTraceListener: TraceListener
    {   
        public enum ePrefixOutput { TIMESTAMP, DATE, TIME, NONE };

        protected static Object syncObject = new Object();
        int iMaxStringLength = 0;
      

        public int IMaxStringLength
        {
            get {
                    if (iMaxStringLength == 0)
                    {
                        try
                        {
                            foreach (DictionaryEntry de in this.Attributes)
                                if (de.Key.ToString().Equals("MaxStringLength", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    iMaxStringLength = Convert.ToInt32(de.Value);

                                }
                        }
                        catch { }
                        if (iMaxStringLength == 0)
                            iMaxStringLength = 4 * 1024;
                    }
                    return iMaxStringLength;
                }
        } 

        

    public baseWriterTraceListener()
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

    public virtual void TraceEvent(LogEventEntry oWithEvent)
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
    public virtual void TraceEvent(AuditEventEntry oWithEvent)
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
    public virtual void TraceEvent(StatisticEventEntry oWithEvent)
    {
        try
        {
            TracePending.Trace("Base Event Log Generic TraceEvent no method overriden...");

        }
        catch (Exception ex)
        {
            TracePending.Trace(ex.Message);
            throw (ex);
        }

    }
        public override void Write(Object oWithObject)
        {
            try
            {
                EventEntry oEntry = (EventEntry) oWithObject;
                TracePending.Trace("Base Event Log Write...");
                if (oEntry.GetType() == typeof(LogEventEntry))
                    TraceEvent((LogEventEntry)oEntry);
                if (oEntry.GetType() == typeof(AuditEventEntry))
                    TraceEvent((AuditEventEntry)oEntry);
                if (oEntry.GetType() == typeof(StatisticEventEntry))
                    TraceEvent((StatisticEventEntry)oEntry);
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }


        }
        public override void Write(string s)
        {
             
        }


        public override void WriteLine(string s)
        {
           
                        
        }

        public override void TraceEvent(TraceEventCache eCCache, string s, TraceEventType eEventType, int iVal)
        {
            try {
                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        protected override string[] GetSupportedAttributes()
        {
            return new string[] {  };
            
        }

    }

}
