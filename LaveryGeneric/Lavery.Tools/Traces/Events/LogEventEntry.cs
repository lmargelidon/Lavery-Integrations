using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;


namespace Lavery.Events
{
    
    public enum eLevel      { None, Informational, Warning, Error, Fatal, Audit, Statistics }

    public class LogEventEntry : EventEntry
    {

        
        public String sSchema = "Dbo";
        public String sTableName = "LOGEntries";

        public String sComputer = "";
        public String sBusinessFunction = "";
        public String sModule = "";
        public String sClassName = "";
        public String sMethodName = "";
        public String sEnvironment = "";

        public String eCategoryType = "None";
        
        public DateTime dtEvent = DateTime.MinValue;
        public Guid     Correlation = Guid.NewGuid();
        public eLevel   eEventLevel = eLevel.None;
        public String   sDomain = "";
        public String   sUser = "";
        public String   sSid = "";
        public String   sDetail = "";
        public String   sPipeline = "";




        public LogEventEntry(   )
        {
            try 
            {
                
                sSchema = OConnectionFactory.getKeyValueString("LogEntrySchema");
                sTableName = OConnectionFactory.getKeyValueString("LogEntryTable");

            }
            catch (Exception ex)
            {
                
                throw (ex);
            }
        }
        override public EventEntryBase loadEventEntry()
        {
            EventEntryBase oEventBase = default(EventEntryBase);
            try
            {   oEventBase = new EventEntryBase(/*new EventDBSerializer()*/);
                String sEntityName = OConnectionFactory.getKeyValueString("CompagnyName");
                
                if (sEntityName.Length == 0)
                    sEntityName = "LsaDefault";
                //oEventBase.Add("FK_TO_Entities_ENTITYCODE", new EventEntryBase.objectToBeSerialized(sEntityName, typeof(int), default(Object), true, "Dbo", "Entities", String.Format("sCode='{0}'", sEntityName)));

                oEventBase.Add("Computer", new EventEntryBase.objectToBeSerialized(sComputer, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("CategoryName", new EventEntryBase.objectToBeSerialized(sBusinessFunction, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("Module", new EventEntryBase.objectToBeSerialized(sModule, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("ClassName", new EventEntryBase.objectToBeSerialized(sClassName, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("MethodName", new EventEntryBase.objectToBeSerialized(sMethodName, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("fk_Environment", new EventEntryBase.objectToBeSerialized(sEnvironment, typeof(int), default(Object), true, "dbo", "Environment", String.Format("Code='{0}'", sEnvironment)));
                
                oEventBase.Add("CategoryType", new EventEntryBase.objectToBeSerialized(eCategoryType, typeof(String), default(Object), false, "", "", ""));
               
                oEventBase.Add("dtEvent", new EventEntryBase.objectToBeSerialized( dtEvent.ToString("yyyy-MM-ddTHH:mm:ss.fff"), typeof(DateTime), default(Object), false, "", "", ""));
                oEventBase.Add("refGuid", new EventEntryBase.objectToBeSerialized(Correlation.ToString(), typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("EventLevel", new EventEntryBase.objectToBeSerialized(eEventLevel.ToString(), typeof(String), default(Object),  false, "", "", ""));
                oEventBase.Add("User", new EventEntryBase.objectToBeSerialized(sUser, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("comment", new EventEntryBase.objectToBeSerialized(sDetail, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("Pipeline", new EventEntryBase.objectToBeSerialized(sPipeline, typeof(String), default(Object), false, "", "", ""));

                //oEventBase.Publish("Dbo", "LOGEntries");

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oEventBase;
        
        }
  


    }
}
