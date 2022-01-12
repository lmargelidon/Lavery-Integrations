using System.Text;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System;
using Lavery.Tools.Runtime;  
using Lavery.Events;
using Lavery.Tools.XML;

namespace Lavery.Events.Listeners
{
    public class DbmsWriterTraceListener : baseWriterTraceListener
    {

        EventDBSerializer oDbSerializer = default(EventDBSerializer);
        
        
        /*
        public String Source
        {
            get
            {
                if (source.Length == 0)
                {
                    foreach (DictionaryEntry de in this.Attributes)
                        if (de.Key.ToString().ToLower() == "source")
                            source = de.Value.ToString();
                }
                return source;
            }
            set { source = value; }
        }
        
       
        public String SSchema
        {
            get
            {
                if (sSchema.Length == 0)
                {
                    foreach (DictionaryEntry de in this.Attributes)
                        if (de.Key.ToString().ToLower() == "Schema")
                            sSchema = de.Value.ToString();
                }
                return sSchema;
            }
            set { sSchema = value; }

            
        }
        */
        public DbmsWriterTraceListener(string sWithAppSetingEntry)
        {
            try
            {
               //TracePending.Trace(String.Format("DbmsWriterTraceListener App Setting: ", sWithAppSetingEntry));
                oDbSerializer  =  new EventDBSerializer(sWithAppSetingEntry);
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
            {/*
                if (!bOpenned)
                {

                    foreach (DictionaryEntry de in this.Attributes)
                    {
                        if (de.Key.ToString().Equals("Schema", StringComparison.CurrentCultureIgnoreCase))
                            sSchema = de.Value.ToString();
                        if (de.Key.ToString().Equals("source", StringComparison.CurrentCultureIgnoreCase))
                            source = de.Value.ToString();
                    }
                    bOpenned = true;
                }
              */    
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
                
                String sSchema = "";
                String sTable = "";
              
                sSchema = oWithEvent.sSchema;
                sTable = oWithEvent.sTableName;
                if (oWithEvent.sDetail.Length > IMaxStringLength)
                    oWithEvent.sDetail = oWithEvent.sDetail.Substring(0, IMaxStringLength);
                EventEntryBase oEventData = oWithEvent.loadEventEntry();
                oDbSerializer.recordEvent(sSchema, sTable, oEventData);
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
                lock(syncObject)
                {
                    String sSchema = "";
                    String sTable = "";

                    sSchema = oWithEvent.sSchema;
                    sTable = oWithEvent.sTableName;
                    if (oWithEvent.sOldValues.Length > IMaxStringLength)
                        oWithEvent.sOldValues = oWithEvent.sOldValues.Substring(0, IMaxStringLength);
                    if (oWithEvent.sNewValues.Length > IMaxStringLength)
                        oWithEvent.sNewValues = oWithEvent.sNewValues.Substring(0, IMaxStringLength);
                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    oDbSerializer.recordEvent(sSchema, sTable, oEventData);
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

                    String sSchema = "";
                    String sTable = "";

                    sSchema = oWithEvent.sSchema;
                    sTable = oWithEvent.sTableName;

                    EventEntryBase oEventData = oWithEvent.loadEventEntry();
                    oDbSerializer.recordEvent(sSchema, sTable, oEventData);
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }

        }
        
        protected override String[] GetSupportedAttributes()
        {
            return new string[] { "SChema", "source" };
            
        }

    }

}
