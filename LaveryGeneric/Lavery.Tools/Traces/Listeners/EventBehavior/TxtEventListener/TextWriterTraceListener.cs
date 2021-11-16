using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Collections;

using Lavery.Tools.Runtime;  
using Lavery.Events;
using Lavery.Tools.IO;

namespace Lavery.Events.Listeners
{
    public class TextWriterTraceListener : baseWriterTraceListener
    {  

        string source;
        bool  bTestSource;
        string sFileToLog;

        FileStreamSynchronized oFileStream = default(FileStreamSynchronized);
        Object syncTrace = new Object();


        ePrefixOutput ePrefix = ePrefixOutput.NONE;


        public TextWriterTraceListener(string listenerLogFile)
        {
            try
            {   
                sFileToLog  = listenerLogFile;
                bTestSource = false;
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

                if (oFileStream == default(FileStreamSynchronized))
                {
                    foreach (DictionaryEntry de in this.Attributes)
                    {
                        if (de.Key.ToString().Equals("testsource", StringComparison.CurrentCultureIgnoreCase))
                            bTestSource = de.Value.ToString() == "1";
                    }

                    bool bAppend = false;
                    foreach (DictionaryEntry de in this.Attributes)
                    {
                        if (de.Key.ToString().Equals("append", StringComparison.CurrentCultureIgnoreCase))
                            bAppend = de.Value.ToString() == "1";
                    }

                    lock (syncTrace)
                    {
                        if (oFileStream == default(FileStreamSynchronized))
                        {
                            try
                            {

                                oFileStream = new FileStreamSynchronized(true, sFileToLog);
                                oFileStream.Open(bAppend ? FileMode.Append : FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite, 4000, FileOptions.Asynchronous);
                            }
                            catch
                            {
                                oFileStream.Open( FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite, 4000, FileOptions.Asynchronous);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

        }
        
        public string Source
        {
            get
            {  
                foreach (DictionaryEntry de in this.Attributes)
                    if (de.Key.ToString().Equals("source", StringComparison.CurrentCultureIgnoreCase))
                        source = de.Value.ToString();
                return source;
            }
            set { source = value; }
        }
        public ePrefixOutput EPrefix
        {
            get
            {
                try
                {
                    foreach (DictionaryEntry de in this.Attributes)
                    {
                        if (de.Key.ToString().Equals("timestamp", StringComparison.CurrentCultureIgnoreCase) &&
                            de.Value.ToString() == "1")
                        {
                            ePrefix = ePrefixOutput.TIMESTAMP;
                            break;
                        }
                        if (de.Key.ToString().Equals("date", StringComparison.CurrentCultureIgnoreCase) &&
                            de.Value.ToString() == "1")
                        {
                            ePrefix = ePrefixOutput.DATE;
                            break;
                        }
                        if (de.Key.ToString().Equals("time", StringComparison.CurrentCultureIgnoreCase) &&
                            de.Value.ToString() == "1")
                        {
                            ePrefix = ePrefixOutput.TIME;
                            break;
                        }

                    }
                }
                catch 
                {
                    
                }
                return ePrefix;
            }
            
        }
        

        protected String formatTraceOutput(string sWithOutMessage)
        {
            String sOutMessage = "";
            try
            {
                sOutMessage = "";
                if (EPrefix == ePrefixOutput.TIMESTAMP ||
                    EPrefix == ePrefixOutput.DATE)
                    sOutMessage +=   DateTime.Now.Year + "\\" + DateTime.Now.Month + "\\" + DateTime.Now.Day;
                if (EPrefix == ePrefixOutput.TIMESTAMP)
                    sOutMessage += "-";
                if (EPrefix == ePrefixOutput.TIMESTAMP ||
                    EPrefix == ePrefixOutput.TIME)
                    sOutMessage += DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond;
                if (EPrefix != ePrefixOutput.NONE)
                    sOutMessage += "\t";
                sOutMessage += sWithOutMessage;
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return sOutMessage;
        }
        public void TraceEvent(String sWithBuffer)
        {
            try
            {

                if (oFileStream != default(FileStreamSynchronized))
                {
                    lock (syncTrace)
                    {
                        try
                        {

                            oFileStream.WriteLine(sWithBuffer, 0, SeekOrigin.End);
                        }
                        catch (Exception ex)
                        {
                            throw (ex);
                        }
                 
                    }

                }
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
                if (oWithEvent.sDetail.Length > IMaxStringLength)
                    oWithEvent.sDetail = oWithEvent.sDetail.Substring(0, IMaxStringLength);
                String sSerializedData = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",
                                                                oWithEvent.dtEvent,
                                                                oWithEvent.Correlation,
                                                                oWithEvent.sEnvironment,
                                                                oWithEvent.eEventLevel.ToString(),
                                                                oWithEvent.sBusinessFunction,
                                                                oWithEvent.sComputer,
                                                                oWithEvent.sModule,
                                                                oWithEvent.sClassName,
                                                                oWithEvent.sMethodName,
                                                                oWithEvent.sDetail);                                                                    ;
                TraceEvent(sSerializedData);
                
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
                if (oWithEvent.sOldValues.Length > IMaxStringLength)
                    oWithEvent.sOldValues = oWithEvent.sOldValues.Substring(0, IMaxStringLength);
                if (oWithEvent.sNewValues.Length > IMaxStringLength)
                    oWithEvent.sNewValues = oWithEvent.sNewValues.Substring(0, IMaxStringLength);
                String sSerializedData = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}",
                                                               oWithEvent.dtEvent,
                                                               oWithEvent.Correlation,
                                                               oWithEvent.sEnvironment,
                                                               "Security",
                                                               oWithEvent.sBusinessFunction,
                                                               oWithEvent.sComputer,
                                                               oWithEvent.sModule,
                                                               oWithEvent.sClassName,
                                                               oWithEvent.sMethodName,
                                                               oWithEvent.bStatus,
                                                               oWithEvent.eActionTypes,
                                                               oWithEvent.sUserAccount,
                                                               oWithEvent.sUserAccountSid,
                                                               oWithEvent.sSurrogedAccount,
                                                               oWithEvent.sSurrogedAccountSid,
                                                               oWithEvent.sDocumentUrl);    
                TraceEvent(sSerializedData);
 
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
                String sSerializedData = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}",
                                                                oWithEvent.dtEvent,
                                                                oWithEvent.Correlation,
                                                                oWithEvent.sEnvironment,
                                                                "Statistic",
                                                                oWithEvent.sBusinessFunction,
                                                                oWithEvent.sComputer,
                                                                oWithEvent.sModule,
                                                                oWithEvent.sClassName,
                                                                oWithEvent.sMethodName,
                                                                oWithEvent.bStatusSuccess,
                                                                oWithEvent.iInputSizePayLoad, 
                                                                oWithEvent.iOutputSizePayLoad,
                                                                oWithEvent.iDuration); ;
                TraceEvent(sSerializedData);
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
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
            return new string[] { "Source", "Append", "TimeStamp", "Date", "Time","TestSource" };
            
        }

    }

}
