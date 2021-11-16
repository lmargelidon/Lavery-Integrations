using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Lavery.Events
{
    public enum eActionType { None, Insert, Delete, Update, Query, Get, HttpRequest, HttpSessionStart, HttpSessionEnd, Authentication}
    public class AuditEventEntry : EventEntry
    {
        public String sSchema = "Dbo";
        public String sTableName = "AuditEntries";

        public String sComputer = "";
        public String sBusinessFunction = "";
        public String sModule = "";
        public String sClassName = "";
        public String sMethodName = "";
        public String sEnvironment = "";

        public  String sUserAccount = "";
        public String sUserAccountSid = "";
        public String sSurrogedAccount = "";
        public String sSurrogedAccountSid = "";
	    public  String sUserFullName="";        

        public String sDocumentUrl = "";
	    public  Guid Correlation=Guid.NewGuid();
        public DateTime dtEvent = DateTime.Now;
        
	    public  String sOldValues="";
	    public  String sNewValues="";
        public  eActionType eActionTypes = eActionType.None;
        public  Boolean bStatus = false;

       

        public AuditEventEntry()
        {
            try 
            {
                
                 
            }
            catch (Exception ex)
            {                
                throw (ex);
            }
        }
        public void addDataValue(String sWithFiledName, Object oWithValue, Boolean bWithNewValue)
        {
            try 
            {
                String sValue = String.Format("{0}={1}\n", sWithFiledName, oWithValue.ToString());
                if (bWithNewValue)
                    sNewValues += sValue;
                else
                    sOldValues += sValue;
            
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

                oEventBase.Add("eActionTypes", new EventEntryBase.objectToBeSerialized(eActionTypes.ToString(), typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sUserAccount", new EventEntryBase.objectToBeSerialized(sUserAccount, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sUserAccountSid", new EventEntryBase.objectToBeSerialized(sUserAccountSid, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sSurrogedAccount", new EventEntryBase.objectToBeSerialized(sSurrogedAccount, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sSurrogedAccountSid", new EventEntryBase.objectToBeSerialized(sSurrogedAccountSid, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sUserFullName", new EventEntryBase.objectToBeSerialized(sUserFullName, typeof(String), default(Object), false, "", "", ""));
               
               
                oEventBase.Add("sDocumentUrl", new EventEntryBase.objectToBeSerialized(sDocumentUrl, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("dtEvent", new EventEntryBase.objectToBeSerialized(dtEvent.ToString("yyyy-MM-ddTHH:mm:ss.fff"), typeof(DateTime), default(Object), false, "", "", ""));
          
                oEventBase.Add("Correlation", new EventEntryBase.objectToBeSerialized(Correlation.ToString(), typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sOldValues", new EventEntryBase.objectToBeSerialized(sOldValues, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("sNewValues", new EventEntryBase.objectToBeSerialized(sNewValues, typeof(String), default(Object), false, "", "", ""));
                oEventBase.Add("Status", new EventEntryBase.objectToBeSerialized(bStatus, typeof(Boolean), default(Object), false, "", "", ""));
                //oEventBase.Publish("Dbo", "AuditEntries");
               
            }
            catch (Exception ex)
            {
                throw (ex);
                
            }
            return oEventBase;
        
        }
  

    }
}
