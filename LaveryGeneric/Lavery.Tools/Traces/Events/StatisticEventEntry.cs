using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






namespace Lavery.Events
{
    public class StatisticEventEntry : EventEntry
    {
        public String sSchema = "Dbo";
        public String sTableName = "StatisticEntries";

        public String sComputer = "";
        public String sBusinessFunction = "";
        public String eCategoryType = "None";
        public String sModule = "";
        public String sClassName = "";
        public String sMethodName = "";
        public String sEnvironment = "";
        
        public DateTime dtEvent = DateTime.MinValue;
        public Guid     Correlation = Guid.NewGuid();
        public int      iInputSizePayLoad = 0;
        public int      iOutputSizePayLoad = 0;
        public int      iDuration = 0;
        public Boolean  bStatusSuccess = true;
	    
	    
        public StatisticEventEntry()
        {
            try 
            {
                                 
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
            {
                oEventBase = new EventEntryBase(/*new EventDBSerializer()*/);
                String sEntityName = System.Configuration.ConfigurationManager.AppSettings["CompagnyName"];
                if (sEntityName.Length == 0)
                    sEntityName = "LsaDefault";
                oEventBase.Add("FK_TO_Entities_ENTITYCODE", new EventEntryBase.objectToBeSerialized(sEntityName, typeof(int), default(Object), true, "Dbo", "Entities", String.Format("sCode='{0}'", sEntityName)));

                oEventBase.Add("sComputer", new EventEntryBase.objectToBeSerialized(sComputer, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sBusinessFunction", new EventEntryBase.objectToBeSerialized(sBusinessFunction, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sModule", new EventEntryBase.objectToBeSerialized(sModule, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sClassName", new EventEntryBase.objectToBeSerialized(sClassName, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sMethodName", new EventEntryBase.objectToBeSerialized(sMethodName, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sEnvironment", new EventEntryBase.objectToBeSerialized(sEnvironment, typeof(String), default(Object), false, "", "", ""));

                oEventBase.Add("eCategoryType", new EventEntryBase.objectToBeSerialized(eCategoryType.ToString(), typeof(String), default(Object), false, "", "", ""));

                oEventBase.Add("dtEvent", new EventEntryBase.objectToBeSerialized(dtEvent.ToString("yyyy-MM-ddTHH:mm:ss.fff"), typeof(DateTime), default(Object), false, "", "", ""));
                oEventBase.Add("Correlation", new EventEntryBase.objectToBeSerialized(Correlation.ToString(), typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("iInputSizePayLoad", new EventEntryBase.objectToBeSerialized(iInputSizePayLoad.ToString(), typeof(int), default(Object), false, "", "", ""));
                oEventBase.Add("iOutputSizePayLoad", new EventEntryBase.objectToBeSerialized(iOutputSizePayLoad.ToString(), typeof(int), default(Object), false, "", "", ""));
                oEventBase.Add("iDuration", new EventEntryBase.objectToBeSerialized(iDuration.ToString(), typeof(int), default(Object), false, "", "", ""));
                oEventBase.Add("bStatusSuccess", new EventEntryBase.objectToBeSerialized(bStatusSuccess, typeof(Boolean), default(Object), false, "", "", ""));
                
                // oEventBase.Publish("Dbo", "StatisticEntries");
               
            }
            catch (Exception ex)
            {
                throw (ex);
                
            }
            return oEventBase;
        
        }
  
    }
}
