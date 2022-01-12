using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Principal;
using System.Net;
using Lavery.Tools.XML;
using System.Diagnostics;
using Lavery.Events;

//using WCFServices.Clients;
using Lavery.Events.Listeners; 
using Lavery.Tools.Runtime;  
using System.Threading.Tasks;
using Lavery.Tools.RunTime;

namespace Lavery.Events.Listeners
{
    
    public static class persistEventManager
    {
        
        public enum eDiagnostic { Nothing, Information, Warning, Audit,Error, Critical };
        //public enum eEventOrigin { nothing, LogingServices, EventLogServices, AuditServices,AuditLogServices, StatisticServices,StatisticLogServices, AlertServices };
        public enum eEventOrigin { nothing, LogingServices, AuditServices,  StatisticServices};

        private static object syncLock = new object();
        static List<IDynamicEvents> lOfLog = new List<IDynamicEvents>();


        [STAThread]
        public static void init()
        {
            try
            {
                //TracePending.Trace("Initialize persistEventManager " + lOfLog.Count.ToString());
                
                if (lOfLog.Count == 0)
                {
                    lock (syncLock)
                    {
                        if (lOfLog.Count == 0)
                        {
                            String [] lEvent = Enum.GetNames(typeof(eEventOrigin));
                            foreach (String sEventName in lEvent)
                                if (!sEventName.Equals("Nothing", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    try
                                    {
                                        //TracePending.Trace(String.Format("Add Logger {0}", sEventName));    
                                        lOfLog.Add(FactoryBuilder.createDynamicEvents(sEventName, true, false));
                                    }
                                    catch (Exception ex)
                                    {
                                        TracePending.Trace(ex.Message);                                        
                                    }
                                }

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                         
            }

        }
        static IDynamicEvents getLogger(eEventOrigin eOrigin)
        {
            IDynamicEvents oRet = null;
            try
            {
                lock (syncLock)
                {
                    foreach (IDynamicEvents oLog in lOfLog)
                    {

                        if (oLog.getName().Equals(eOrigin.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            oRet = oLog;
                            break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }

            return oRet;
        }
       
        static public Boolean isTraceLevelActivate(IDynamicEvents oLog, SourceLevels eWithCurrent)
        {
            Boolean bRet = false;
            try
            {
                if (oLog != default(IDynamicEvents))
                {
                    switch (eWithCurrent)
                    {
                        case SourceLevels.Critical:
                            bRet = true;
                            break;
                        case SourceLevels.Error:
                            if (oLog.getTraceLevel() == SourceLevels.Error ||
                                oLog.getTraceLevel() == SourceLevels.ActivityTracing ||
                                oLog.getTraceLevel() == SourceLevels.Warning ||
                                oLog.getTraceLevel() == SourceLevels.Information ||
                                oLog.getTraceLevel() == SourceLevels.Verbose)
                                bRet = true;
                            break;
                        case SourceLevels.ActivityTracing:
                            if (oLog.getTraceLevel() == SourceLevels.ActivityTracing ||
                                oLog.getTraceLevel() == SourceLevels.Warning ||
                                oLog.getTraceLevel() == SourceLevels.Information ||
                                oLog.getTraceLevel() == SourceLevels.Verbose)
                                bRet = true;
                            break;
                        case SourceLevels.Warning:
                            if (oLog.getTraceLevel() == SourceLevels.Warning ||
                                oLog.getTraceLevel() == SourceLevels.Information ||
                                oLog.getTraceLevel() == SourceLevels.Verbose)
                                bRet = true;
                            break;
                        case SourceLevels.Information:
                            if (oLog.getTraceLevel() == SourceLevels.Information ||
                                oLog.getTraceLevel() == SourceLevels.Verbose)
                                bRet = true;
                            break;
                        case SourceLevels.Verbose:
                            if (oLog.getTraceLevel() == SourceLevels.Verbose)
                                bRet = true;
                            break;

                    }
                }
                /*
                else
                    TracePending.Trace("isTraceLevelActivate Logger null...");
                */

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                
            }

            return bRet;
        }
        static String fillAndSerializeEventInformation(String sClassName, String sMethodName, String sAssemblyName, LogEventEntry oEntry, String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, String sWithInformation, String oCorrelation)
        {
            String sRet = "";
            try
            {
                oEntry.eCategoryType = eWithCategory;
                oEntry.sDetail = sWithInformation;
                if (oCorrelation.Length == 0)
                    oEntry.Correlation = Guid.NewGuid();
                else
                    oEntry.Correlation = new Guid(oCorrelation);
                oEntry.dtEvent = DateTime.Now;
                oEntry.sComputer = Dns.GetHostName();
                oEntry.sUser = WindowsIdentity.GetCurrent().Name;
                oEntry.sSid = WindowsIdentity.GetCurrent().User.ToString();
                oEntry.sDomain = "";

               /*String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);*/

                oEntry.sComputer = Dns.GetHostName();
                oEntry.sBusinessFunction = sWithBusinessFunction;
                oEntry.sModule = sAssemblyName;
                oEntry.sClassName = sClassName;
                oEntry.sMethodName = sMethodName;
                oEntry.sEnvironment = sWithEnvironment;


                sRet = SerializeMessage.serialize(oEntry);
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return sRet;
        }
        public static void logAudit(eActionType eWithActionType, String sWithBusinessFunction, String sWithEnvironment, Boolean bWithStatus, String sWithSurrogedUID, String sWithSurrogedSid,  String sWithOLdValue, String sWithNewValue, String sWithDocumentUrl, String oCorrelation)
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() => 
                               {
                                   //TracePending.Trace("Trace Runing..");
                                   IDynamicEvents oLog = getLogger(eEventOrigin.AuditServices);
                                  
                                   if (isTraceLevelActivate(oLog, SourceLevels.ActivityTracing))
                                   {
                                      
                                       AuditEventEntry oEntry = new AuditEventEntry();
                                       oEntry.Correlation = new Guid(oCorrelation);
                                       oEntry.eActionTypes = eWithActionType;
                                       oEntry.dtEvent = DateTime.Now;
                                      
                                       oEntry.sUserAccount = WindowsIdentity.GetCurrent().Name;
                                       oEntry.sUserAccountSid = WindowsIdentity.GetCurrent().User.ToString();
                                       oEntry.sSurrogedAccount = sWithSurrogedUID;
                                       oEntry.sSurrogedAccountSid = sWithSurrogedSid;
                                       oEntry.sOldValues = sWithOLdValue;
                                       oEntry.sNewValues = sWithNewValue;
                                       oEntry.sDocumentUrl = sWithDocumentUrl;
                                       oEntry.bStatus = bWithStatus;
                                       
                                       oEntry.sComputer = Dns.GetHostName();
                                       oEntry.sBusinessFunction = sWithBusinessFunction;
                                       oEntry.sModule = sAssemblyName;
                                       oEntry.sClassName = sClassName;
                                       oEntry.sMethodName= sMethodName ;
                                       oEntry.sEnvironment = sWithEnvironment;

                                       String sDoc = SerializeMessage.serialize(oEntry);
                                       lock (syncLock)
                                       {
                                           oLog.TraceEvent(oEntry);
                                       }
                                       ////oEvent.propageEvent(sRet, eEventType.Audit);
                                   }
                                   });
                    taskA.Start();
                    //TracePending.Trace("Trace Started");

                }
                catch (Exception ex)
                {
                    TracePending.Trace(ex.Message);                
                }
            }

        public static void logStatistic(String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, int iWithInputSizePayLoad, int iWithOutputSizePayLoad, int iWithDuration, String oCorrelation)
            {
                try
                {
                    logStatistic(eWithCategory, sWithBusinessFunction, sWithEnvironment, iWithInputSizePayLoad, iWithOutputSizePayLoad, iWithDuration, oCorrelation, true);
                }
                catch (Exception ex)
                {
                    TracePending.Trace(ex.Message);
                }
        }
        public static void logStatistic(String eWithCategory, String sWithBusinessFunction, 
                                        String sWithEnvironment, int iWithInputSizePayLoad, int iWithOutputSizePayLoad, int iWithDuration, 
                                        String oCorrelation, Boolean bWithStatusSuccess)
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                {
                    //TracePending.Trace("Get Logger...");
                    IDynamicEvents oLog = getLogger(eEventOrigin.StatisticServices);

                    if (isTraceLevelActivate(oLog, SourceLevels.ActivityTracing))
                    {
                        //TracePending.Trace("Logger Found ...");
                        StatisticEventEntry oEntry = new StatisticEventEntry();
                        oEntry.Correlation = new Guid(oCorrelation);
                        oEntry.dtEvent = DateTime.Now;

                        oEntry.iInputSizePayLoad = iWithInputSizePayLoad;
                        oEntry.iOutputSizePayLoad = iWithOutputSizePayLoad;
                        oEntry.iDuration = iWithDuration;
                        oEntry.eCategoryType = eWithCategory;

                        oEntry.sComputer = Dns.GetHostName();
                        oEntry.sBusinessFunction = sWithBusinessFunction;
                        oEntry.sModule = sAssemblyName;
                        oEntry.sClassName = sClassName;
                        oEntry.sMethodName = sMethodName;
                        oEntry.sEnvironment = sWithEnvironment;
                        oEntry.bStatusSuccess = bWithStatusSuccess;
                        lock (syncLock)
                        {

                            oLog.TraceEvent(oEntry);
                        }
                    }
                    /*
                    else
                        TracePending.Trace("No listener available...");
                    */

                });
                taskA.Start();

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }

        public static void logInformation(String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, String sWithInformation, String oCorrelation, String sWithPipeline = "None")
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                                {
                                    //TracePending.Trace("getLogger for logInformation ");
                                    IDynamicEvents oLog = getLogger(eEventOrigin.LogingServices);
                                    
                                    if (isTraceLevelActivate(oLog, SourceLevels.Information))
                                    {
                                        //TracePending.Trace("Apres  isTraceLevelActivate");
                                        LogEventEntry oEntry = new LogEventEntry();
                                        oEntry.eEventLevel = eLevel.Informational;
                                        oEntry.sPipeline = sWithPipeline;

                                        String sDoc = fillAndSerializeEventInformation(sClassName, sMethodName, sAssemblyName, oEntry, eWithCategory, sWithBusinessFunction, sWithEnvironment, sWithInformation, oCorrelation);
                                        lock (syncLock)
                                        {
                                            //TracePending.Trace("TraceEvent launched ");
                                            oLog.TraceEvent(oEntry);
                                        }
                                    }
                                    /*
                                    else
                                        TracePending.Trace("logInformation not activated...");
                                    */
                                });
                taskA.Start();

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logWarning(String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, String sWithInformation, String oCorrelation, String sWithPipeline = "None")
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                                {
                                    IDynamicEvents oLog = getLogger(eEventOrigin.LogingServices);

                                    if (isTraceLevelActivate(oLog, SourceLevels.Warning))
                                    {
                                        
                                        LogEventEntry oEntry = new LogEventEntry();
                                        oEntry.eEventLevel = eLevel.Warning;
                                        oEntry.sPipeline = sWithPipeline;
                                        String sDoc = fillAndSerializeEventInformation(sClassName, sMethodName, sAssemblyName, oEntry, eWithCategory, sWithBusinessFunction, sWithEnvironment, sWithInformation, oCorrelation);
                                        lock (syncLock)
                                        {
                                            oLog.TraceEvent(oEntry);
                                        }
                                    }
                                     });
                taskA.Start();

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logError(String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, String sWithInformation, String oCorrelation, String sWithPipeline = "None")
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                                {
                                    IDynamicEvents oLog = getLogger(eEventOrigin.LogingServices);

                                    if (isTraceLevelActivate(oLog, SourceLevels.Error))
                                    {
                                        
                                        LogEventEntry oEntry = new LogEventEntry();
                                        oEntry.eEventLevel = eLevel.Error;
                                        oEntry.sPipeline = sWithPipeline;
                                        String sDoc = fillAndSerializeEventInformation(sClassName, sMethodName, sAssemblyName, oEntry, eWithCategory, sWithBusinessFunction, sWithEnvironment, sWithInformation, oCorrelation);
                                        lock (syncLock)
                                        {
                                            oLog.TraceEvent(oEntry);
                                        }
                                    }
                                });
                taskA.Start();
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logCritical(String eWithCategory, String sWithBusinessFunction, String sWithEnvironment, String sWithInformation, String oCorrelation, String sWithPipeline = "None")
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                               {
                                   IDynamicEvents oLog = getLogger(eEventOrigin.LogingServices);

                                   if (isTraceLevelActivate(oLog, SourceLevels.Critical))
                                   {
                                       
                                       LogEventEntry oEntry = new LogEventEntry();
                                       oEntry.eEventLevel = eLevel.Fatal;
                                       oEntry.sPipeline = sWithPipeline;
                                       String sDoc = fillAndSerializeEventInformation(sClassName, sMethodName, sAssemblyName, oEntry, eWithCategory, sWithBusinessFunction, sWithEnvironment, sWithInformation, oCorrelation);
                                       lock (syncLock)
                                       {
                                           oLog.TraceEvent(oEntry);
                                       }
                                   }
                                });
                taskA.Start();

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logEvent(AuditEventEntry oEvent)
        {
            try
            {
                String sClassName = "";
                String sMethodName = "";
                String sAssemblyName = "";
                RunTimeClass.getRuntimeInformation(ref sAssemblyName, ref sClassName, ref sMethodName);
                var taskA = new Task(() =>
                              {
                                  IDynamicEvents oLog = getLogger(eEventOrigin.AuditServices);

                                  if (isTraceLevelActivate(oLog, SourceLevels.ActivityTracing))
                                  {
                                      lock (syncLock)
                                      {
                                          oLog.TraceEvent(oEvent);
                                      }
                                  }

                              });
                taskA.Start();

            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logEvent(StatisticEventEntry oEntry)
        {
            try
            {
                 var taskA = new Task(() =>
                              {
                                    IDynamicEvents oLog = getLogger(eEventOrigin.StatisticServices);

                                    if (isTraceLevelActivate(oLog, SourceLevels.ActivityTracing))
                                    {
                                        lock (syncLock)
                                        {
                                            oLog.TraceEvent(oEntry);
                                        }
                                    }
                              });
                 taskA.Start();
                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        public static void logEvent(LogEventEntry oEntry)
        {
            try
            {
                 var taskA = new Task(() =>
                              {
                                IDynamicEvents oLog = getLogger(eEventOrigin.LogingServices);
                                if (oEntry.eEventLevel == eLevel.Informational && isTraceLevelActivate(oLog, SourceLevels.Information))
                                    oLog.TraceEvent(oEntry);
                                if (oEntry.eEventLevel == eLevel.Warning && isTraceLevelActivate(oLog, SourceLevels.Warning))
                                    oLog.TraceEvent(oEntry);
                                if (oEntry.eEventLevel == eLevel.Error && isTraceLevelActivate(oLog, SourceLevels.Error))
                                    oLog.TraceEvent(oEntry);
                                if (oEntry.eEventLevel == eLevel.Fatal && isTraceLevelActivate(oLog, SourceLevels.Critical))
                                    oLog.TraceEvent(oEntry);
                              });
                 taskA.Start();
           
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        }
        /*
        public static void getRuntimeInformation(ref String SwithAssemblyName, ref String SwithClassName, ref String sWithMethodName)
        {
            try
            {

                StackTrace stackTrace = new StackTrace();
                StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)


                foreach (StackFrame stackFrame in stackFrames)
                {
                    
                    if (!stackFrame.GetMethod().Name.ToString().Equals("fillAndSerializeEventInformation", StringComparison.CurrentCultureIgnoreCase) &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("logInformation", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("LOG", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("logWarning", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("logError", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("logFatal", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        !stackFrame.GetMethod().Name.ToString().Equals("getRuntimeInformation", StringComparison.CurrentCultureIgnoreCase) &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("LogAudit", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("logStatistic", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("portalLogger", StringComparison.CurrentCultureIgnoreCase) &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("ForWorker", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("InnerInvoke", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("Task", StringComparison.CurrentCultureIgnoreCase) &&
                        stackFrame.GetMethod().Name.ToString().IndexOf("ExecuteSelf", StringComparison.CurrentCultureIgnoreCase) < 0 &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("ExecutionContext", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("ThreadPoolTaskScheduler", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("TaskScheduler", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("Parallel", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("ThreadPoolWorkQueue", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("TracePending", StringComparison.CurrentCultureIgnoreCase) &&
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("_ThreadPoolWaitCallback", StringComparison.CurrentCultureIgnoreCase)
                        
                        

                        )
                    {
                        SwithAssemblyName = stackFrame.GetMethod().ReflectedType.Assembly.ManifestModule.Name;                    
                        SwithClassName = stackFrame.GetMethod().DeclaringType.Name.ToString();
                        sWithMethodName = stackFrame.GetMethod().Name.ToString();
                        break;

                    }

                }


            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
        }
        */
    }
}
        