using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using LsaEvents.Propagation;




namespace LsaEvent.EventBehavior
{
    public class DynamicEventsManager
    {
        public enum eDiagnostic { Nothing, Information,Warning, Error, Fatal};
        public enum eEventOrigin { nothing, DefaultServiceLoging, TraceGeneric };
        
        private static object syncLock = new object();
        static List<IDynamicEvents> lOfLog = new List<IDynamicEvents>();
        

        

        [STAThread]
        public static void init()
        {
            try
            {
                if (lOfLog.Count == 0)
                {
                    lock (syncLock)
                    {
                        if (lOfLog.Count == 0)
                        {
                            lOfLog.Add(FactoryBuilder.createDynamicEvents("DefaultServiceLoging", true, true));
                            lOfLog.Add(FactoryBuilder.createDynamicEvents("TraceGeneric", true, true));
                            
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        static IDynamicEvents getLogger(eEventOrigin eOrigin)
        {
            IDynamicEvents oRet = null;
            try
            {
                foreach (IDynamicEvents oLog in lOfLog)
                {

                    if(oLog.getName().Equals(eOrigin.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        oRet = oLog;
                        break;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                throw (ex);
                }

            return oRet;        
        }
        static public void doLogEvent(IDynamicEvents oLog, eDiagnostic eWithDiag, String sClassFrom, String sMethodFrom, String SwithError, String sWithMessage)
        {
            try
            {
                lock (syncLock)
                {                    
                  
                    String sName = "";

                    
                    if (eWithDiag == eDiagnostic.Information)
                        oLog.TraceInformation("Information\t" + sName + "\t" + sClassFrom + "->" + sMethodFrom + "\t" + sWithMessage);
                    if (eWithDiag == eDiagnostic.Warning)
                        oLog.TraceWarning("Warning\t" + sName + "\t" + sClassFrom + "->" + sMethodFrom + "\t" + sWithMessage);
                    if (eWithDiag == eDiagnostic.Error ||
                        eWithDiag == eDiagnostic.Fatal)
                        oLog.TraceError("Error\t" + sName + "\t" + sClassFrom + "->" + sMethodFrom + "\t" + sWithMessage);
                   
                }
            }
            catch(Exception ex)
            {
                throw (ex);  
            }
        }
        static public Boolean isTraceLevelActivate(IDynamicEvents oLog, SourceLevels eWithCurrent)
        {
            Boolean bRet = false;
            try
            {
                switch (eWithCurrent)
                {
                    case SourceLevels.Critical:
                        bRet = true;
                        break;
                    case SourceLevels.Error:
                        if (oLog.getTraceLevel() != SourceLevels.Critical)
                            bRet = true;
                        break;
                    case SourceLevels.Warning:
                        if (oLog.getTraceLevel() != SourceLevels.Critical && oLog.getTraceLevel() != SourceLevels.Error)
                            bRet = true;
                        break;
                    case SourceLevels.Information:
                        if (oLog.getTraceLevel() != SourceLevels.Critical && 
                            oLog.getTraceLevel() != SourceLevels.Error &&
                            oLog.getTraceLevel() != SourceLevels.Warning)
                            bRet = true;
                        break;
                    case SourceLevels.Verbose:
                        if (oLog.getTraceLevel() != SourceLevels.Critical &&
                            oLog.getTraceLevel() != SourceLevels.Error &&
                            oLog.getTraceLevel() != SourceLevels.Warning &&
                            oLog.getTraceLevel() != SourceLevels.Information)
                            bRet = true;
                        break; 
                   
                }
            
            }
            catch (Exception ex)
            { 
                bRet = false; 
            }

            return bRet;
        }
        static public void doLogEssai(String sVal)
        {
            try
            {
                IDynamicEvents oLog = getLogger(eEventOrigin.TraceGeneric);

                if (isTraceLevelActivate(oLog, SourceLevels.Information))
                {
                    String sClassFrom = "";
                    String sMethodFrom = "";
                    getRuntimeInformation(oLog.getTraceLevel(), ref sClassFrom, ref sMethodFrom);

                    doLogEvent(oLog, eDiagnostic.Information, sClassFrom, sMethodFrom, "", sVal);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        static public void doLogVerbose(String sVal)
        {
            try
            {
                IDynamicEvents oLog = getLogger(eEventOrigin.DefaultServiceLoging);
                if (isTraceLevelActivate(oLog, SourceLevels.Verbose))
                {
                    String sClassFrom = "";
                    String sMethodFrom = "";
                    getRuntimeInformation(oLog.getTraceLevel(),ref sClassFrom, ref sMethodFrom);

                    doLogEvent(oLog , eDiagnostic.Information, sClassFrom, sMethodFrom, "", sVal);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        static public void doLogInformation(String sVal)
        {
            try
            {
                IDynamicEvents oLog = getLogger(eEventOrigin.DefaultServiceLoging);
                if (isTraceLevelActivate(oLog, SourceLevels.Information))
                {
                    String sClassFrom = "";
                    String sMethodFrom = "";
                    getRuntimeInformation(oLog.getTraceLevel(),ref sClassFrom, ref sMethodFrom);

                    doLogEvent(oLog, eDiagnostic.Information, sClassFrom, sMethodFrom, "", sVal);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        static public void doLogWarning(String sVal)
        {
            try
            {
                IDynamicEvents oLog = getLogger(eEventOrigin.DefaultServiceLoging);
                if (isTraceLevelActivate(oLog, SourceLevels.Warning))                
                {
                    String sClassFrom = "";
                    String sMethodFrom = "";
                    getRuntimeInformation(oLog.getTraceLevel(),ref sClassFrom, ref sMethodFrom);

                    doLogEvent(oLog, eDiagnostic.Warning, sClassFrom, sMethodFrom, "", sVal);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        static public void doLogError( String sVal)
        {
            try
            {
                IDynamicEvents oLog = getLogger(eEventOrigin.DefaultServiceLoging);
                if (isTraceLevelActivate(oLog, SourceLevels.Error))
                {
                    String sClassFrom = "";
                    String sMethodFrom = "";
                    getRuntimeInformation(oLog.getTraceLevel(),ref sClassFrom, ref sMethodFrom);

                    doLogEvent(oLog, eDiagnostic.Error, sClassFrom, sMethodFrom, "\t<Exception Raised>\t", sVal);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        static void getRuntimeInformation(SourceLevels eSourceLevel,ref String SwithClassName, ref String sWithMethodName)
        {
            try
            {
                if (eSourceLevel != SourceLevels.Off)
                {
                    StackTrace stackTrace = new StackTrace();
                    StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)

                    
                    foreach (StackFrame stackFrame in stackFrames)
                    {
                        if (!stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("DynamicEventsManager", StringComparison.CurrentCultureIgnoreCase) &&
                            !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("getRuntimeInformation", StringComparison.CurrentCultureIgnoreCase))
                        {
                            SwithClassName = stackFrame.GetMethod().DeclaringType.Name.ToString();
                            sWithMethodName = stackFrame.GetMethod().Name.ToString();
                            break;

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

