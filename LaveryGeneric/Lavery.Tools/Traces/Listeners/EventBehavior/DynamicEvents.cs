using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Lavery.Events.Listeners; 
using Lavery.Tools.Runtime;  
using Lavery.Events;


namespace Lavery.Events.Listeners
{
    
    [Serializable]
    internal class DynamicEvents : IDynamicEvents
    {
        //private static TraceSwitch appSwitch = null;
        static Object oSync = new Object();
        private TraceSource appTraceSource = null;

       

        static private bool bTraceHeader = false;
        String sTraceName = "";

        static public  bool BTraceHeader
        {
            get { return DynamicEvents.bTraceHeader; }
            set { DynamicEvents.bTraceHeader = value; }
        }


        public DynamicEvents(string sNameOfDBTRace, bool bWithAutoFlush)
        {
            try
            {
                sTraceName = sNameOfDBTRace;
                activeTrace(sNameOfDBTRace, bWithAutoFlush);
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            
            }
                        
        }
        public SourceLevels getTraceLevel()
        {
            SourceLevels oRet = SourceLevels.Off;
            try
            {
                oRet = appTraceSource.Switch.Level;
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
              

            }
            return oRet;
        }
        public String getName()
        {
            return sTraceName;
        }

        private void activeTrace(string sNameOfDBTRace, bool bWithAutoFlush)
        {
            try
            {   
                activeTrace(sNameOfDBTRace);
                System.Diagnostics.Trace.AutoFlush = bWithAutoFlush;
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                
            }
        }
        
        

        public void activeTrace(string sNameOfDBTRace)
        {
            String sVal = "";
            Monitor.Enter(sVal);
            if (appTraceSource == null)
                appTraceSource = new TraceSource(sNameOfDBTRace);
            
            Monitor.Exit(sVal);
            /*
            foreach (TraceListener TL in appTraceSource.Listeners)
            {
                Console.WriteLine(TL.Name + "   sdgsfasf");
            }
            */
            

            Monitor.Enter(appTraceSource);
            try
            {

                if (bTraceHeader)
                {
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "Trace activated...");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "Trace Switches configured into ");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "Trace Switches section " + sNameOfDBTRace + "=" + appTraceSource.Switch.Level.ToString());
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "\t\t 0 --> Off");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "\t\t 1 --> Error");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "\t\t 2 --> Warning");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "\t\t 3 --> Information");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "\t\t 4 --> Verbose");
                    appTraceSource.TraceEvent(TraceEventType.Information, 0, "Trace level is " + (appTraceSource.Switch.Level == SourceLevels.Verbose ? "TraceVerbose" :
                                                                appTraceSource.Switch.Level == SourceLevels.Information ? "TraceInfo" :
                                                                appTraceSource.Switch.Level == SourceLevels.Warning ? "TraceWarning" :
                                                                appTraceSource.Switch.Level == SourceLevels.Error ? "TraceError" : "Off"));
                }
            }
            catch(Exception ex)
            {   
                TracePending.Trace(ex.Message);
               
            }
            Monitor.Exit(appTraceSource);
        }
        
        public void TraceEvent(EventEntry oOutMessage)
        {
            Monitor.Enter(oSync);
            // appTraceSource.TraceEvent(TraceEventType.Information, 1, sOutMessage, new Object[]{"titi","tata"});
            try
            {
               // TracePending.Trace(String.Format("TraceEvent {0} listener pour la source", appTraceSource.Listeners.Count.ToString()));
                foreach (TraceListener oList in appTraceSource.Listeners)
                {
                    oList.Write(oOutMessage);

                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                
            }
            Monitor.Exit(oSync);
        }
        public void TraceEvent(String sOutMessage)
        {
            Monitor.Enter(oSync);
            // appTraceSource.TraceEvent(TraceEventType.Information, 1, sOutMessage, new Object[]{"titi","tata"});
            try
            {
                foreach (TraceListener oList in appTraceSource.Listeners)
                {
                    oList.Write(sOutMessage);

                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                
            }
            Monitor.Exit(oSync);
        }
        
    }
}

