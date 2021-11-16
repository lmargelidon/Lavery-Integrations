using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Lavery.Tools.Interfaces;


namespace Lavery.Tools.DataBaseClassLibrary
{

    

    public class CDBObject 
    {
        public enum eTypeOfConnection { READ, UPDATE };

        

       

        public ConnType.eConnType eType;
               
        protected CDBObject()
        {
            
        }


        /* private CDBErrors listOfErrors;
       private static TraceSwitch appSwitch = null;
       public static void activeTrace(string sNameOfDBTRace)
       {
           if (appSwitch == null)
               appSwitch = new TraceSwitch(sNameOfDBTRace, "Switch in config file");
           
       }
       
        protected void TraceInfo(string sOutDate)
        {
            if (appSwitch !=null && appSwitch.Level == TraceLevel.Off)
                return;
            if (appSwitch != null && appSwitch.Level <= TraceLevel.Info)
                Trace.TraceInformation(sOutDate);
        }
        protected void TraceWarning(string sOutDate)
        {
            if (appSwitch.Level == TraceLevel.Off)
                return;
            if (appSwitch.Level <= TraceLevel.Warning)
                Trace.TraceWarning(sOutDate);
        }
        protected void TraceError(string sOutDate)
        {
            if (appSwitch.Level == TraceLevel.Off)
                return;
            if (appSwitch.Level <= TraceLevel.Error)
                Trace.TraceError(sOutDate);
        }


        public bool registerError(string sWithCode, string sWithMessage)
        {
            bool bRet = false;
            try
            {
                listOfErrors.add(sWithCode, sWithMessage);
                bRet = true;
                Trace.TraceInformation(this.GetType() + "Register Error : " + " <" + sWithMessage + ">"); 
            }
            catch (Exception ex)
            { throw (ex); }
            return bRet;
        }
        */
       
    }
}
