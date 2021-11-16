using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Events.Listeners;
using Lavery.Events;
using System.Collections;
using System.Diagnostics;
using Lavery.Tools.Runtime;  

namespace Lavery.Events.Listeners
{
    class EventViewerTraceListener: baseWriterTraceListener
    {

        EventLog LaveryEventLog = default(EventLog);
        String source = "";
        String sLog = "";
        String sPrefix = "";
       

        public string Source
        {
            get
            {
                if (source.Length == 0)
                {
                    foreach (DictionaryEntry de in this.Attributes)
                        if (de.Key.ToString().Equals("source", StringComparison.CurrentCultureIgnoreCase))
                        {
                            source = sPrefix + de.Value.ToString();

                            if (!EventLog.SourceExists(source))
                                EventLog.CreateEventSource(source, SLog);
                        }
                }
                return source;
            }
            set { source = value; }
        }

        public string SLog
        {

            get
            {
                if (sLog.Length == 0)
                {
                    foreach (DictionaryEntry de in this.Attributes)
                        if (de.Key.ToString().Equals("Log", StringComparison.CurrentCultureIgnoreCase))
                        {
                            sLog = sPrefix + de.Value.ToString();                            
                        }
                }
                return sLog;
            }
            set { sLog = value; }
        }
        public EventViewerTraceListener(string sWithPrefixLog)
        {
            try
            {
                sPrefix = sWithPrefixLog;
                Open();
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        public EventViewerTraceListener()
        {
            try
            {
                
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

        EventLogEntryType getEventLogType(eLevel eWithEventLevel, Boolean bWithSuccess)
        {
            EventLogEntryType oRet = EventLogEntryType.Information;
            try 
            {
                switch (eWithEventLevel)
                {   
                    case eLevel.Error:
                        oRet= EventLogEntryType.Error;
                        break;
                    case eLevel.Fatal:
                        oRet = EventLogEntryType.Error;
                        break;
                    case eLevel.Informational:
                    case eLevel.Statistics:
                        oRet = EventLogEntryType.Information;
                        break;
                    case eLevel.Warning:
                        oRet = EventLogEntryType.Warning;
                        break;
                    case eLevel.Audit:
                        oRet = bWithSuccess ? EventLogEntryType.SuccessAudit: EventLogEntryType.FailureAudit;
                        break;                    
                
                }
            
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return oRet;
        }
        void setEventLog(String sWithSourceName, Boolean bWithForceLog, Boolean bWithForceLogSource)
        {
            try 
            {
                if (bWithForceLog)              
                    EventLog.DeleteEventSource(sWithSourceName);
                if (bWithForceLogSource)
                    EventLog.Delete(SLog);
               
                if (!EventLog.SourceExists(sWithSourceName))
                {
                    EventSourceCreationData oDT = new EventSourceCreationData(sWithSourceName, SLog);
                    EventLog.CreateEventSource(oDT);
                }
                if (LaveryEventLog == default(EventLog))
                    LaveryEventLog = new EventLog(sLog);
                LaveryEventLog.Source = sWithSourceName;
                LaveryEventLog.Log = SLog;
                
            
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
                    if (oWithEvent.sDetail.Length > IMaxStringLength)
                        oWithEvent.sDetail = oWithEvent.sDetail.Substring(0, IMaxStringLength);

                    String sEvent = String.Format("Detail={0}\n\rNode={1}\n\rModule={2}\n\rClass Name={3}\n\rMethod Name={4}\n\rEnvironment={5}\n\rCategory={6}\n\rUserid={7}\n\rDomain={8}\n\r",
                                                                                                                oWithEvent.sDetail, 
                                                                                                                oWithEvent.sComputer,
                                                                                                                oWithEvent.sModule,
                                                                                                                oWithEvent.sClassName,
                                                                                                                oWithEvent.sMethodName,
                                                                                                                oWithEvent.sEnvironment,
                                                                                                                oWithEvent.eCategoryType, 
                                                                                                                oWithEvent.sUser, 
                                                                                                                oWithEvent.sDomain);
                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    try
                    {
                        setEventLog(sPrefix + oWithEvent.eCategoryType.ToString(), false, false);
                    }
                    catch (Exception ex)
                    {
                        TracePending.Trace(ex.Message);
                        setEventLog(sPrefix + oWithEvent.eCategoryType.ToString(), true, false);
                    }

                    LaveryEventLog.WriteEntry(sEvent, getEventLogType(oWithEvent.eEventLevel, true), 1, 1, oWithEvent.Correlation.ToByteArray());
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        public override void TraceEvent(AuditEventEntry oWithEvent)
        {
            try
            {
                
                lock (syncObject)
                {
                    if (oWithEvent.sOldValues.Length > IMaxStringLength)
                        oWithEvent.sOldValues = oWithEvent.sOldValues.Substring(0, IMaxStringLength);
                    if (oWithEvent.sNewValues.Length > IMaxStringLength)
                        oWithEvent.sNewValues = oWithEvent.sNewValues.Substring(0, IMaxStringLength);

                    String sEvent = String.Format("Action={0}\n\rStatus={1}\n\rNode={2}\n\rModule={3}\n\rClass Name={4}\n\rMethod Name={5}\n\rEnvironment={6}\n\rUser Account={7}\n\rUser Account Sid={8}\n\rUser Name={9}\n\rSurroged User={10}\n\rSurroged User Sid={11}\n\rOld Values={12}\n\rNew Values={13}\n\r",
                                                                                                                oWithEvent.eActionTypes.ToString(),
                                                                                                                oWithEvent.bStatus,
                                                                                                                oWithEvent.sComputer,
                                                                                                                oWithEvent.sModule,
                                                                                                                oWithEvent.sClassName,
                                                                                                                oWithEvent.sMethodName,
                                                                                                                oWithEvent.sEnvironment,
                                                                                                                oWithEvent.sUserAccount,
                                                                                                                oWithEvent.sUserAccountSid,
                                                                                                                oWithEvent.sUserFullName,
                                                                                                                oWithEvent.sSurrogedAccount,
                                                                                                                oWithEvent.sSurrogedAccountSid,
                                                                                                                oWithEvent.sOldValues,
                                                                                                                oWithEvent.sNewValues);
                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    try
                    {
                        setEventLog(Source, false, false);
                    }
                    catch 
                    {
                        setEventLog(Source, true, false);
                    }

                    LaveryEventLog.WriteEntry(sEvent, EventLogEntryType.Information, 1, 1, oWithEvent.Correlation.ToByteArray());
                }
                
               
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        public override void TraceEvent(StatisticEventEntry oWithEvent)
        {
            try
            {
                lock (syncObject)
                {

                    String sEvent = String.Format("Node={0}\n\rModule={1}\n\rClass Name={2}\n\rMethod Name={3}\n\rEnvironment={4}\n\rStatus={5}\n\rInput Payload Size={6}\n\rOutput PayLoad Size={7}\n\rElapse time(ms)={8}\n\r",
                                        oWithEvent.sComputer,
                                        oWithEvent.sModule,
                                        oWithEvent.sClassName,
                                        oWithEvent.sMethodName,
                                        oWithEvent.sEnvironment,                                      
                                        oWithEvent.bStatusSuccess,                                        
                                        oWithEvent.iInputSizePayLoad,
                                        oWithEvent.iOutputSizePayLoad,
                                        oWithEvent.iDuration);
                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    try
                    {
                        setEventLog(Source, false, false);
                    }
                    catch 
                    {
                        setEventLog(Source, true, false);
                    }

                    LaveryEventLog.WriteEntry(sEvent, EventLogEntryType.Information, 1, 1, oWithEvent.Correlation.ToByteArray());
                }
                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        
        protected override String[] GetSupportedAttributes()
        {
            return new string[] { "Log", "source" };
            
        }

        
       
    }

}
