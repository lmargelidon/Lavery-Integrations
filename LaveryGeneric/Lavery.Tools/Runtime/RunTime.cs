using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lavery.Tools.RunTime
{
    public class RunTimeClass
    {
        public static Boolean skipStackMethod(String sWithStackMethod, String[] aRefMethodsToSkip)
        {
            Boolean bRet = false;
            try
            {
                if (aRefMethodsToSkip != default(String[]))
                {
                    foreach (String sRefMethod in aRefMethodsToSkip)
                        if (sWithStackMethod.IndexOf(sRefMethod, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            bRet = false;
                            break;
                        }
                }
            }
            catch { }
            return bRet;
        }
        public static void getRuntimeInformation(ref String SwithAssemblyName, ref String SwithClassName, ref String sWithMethodName, String[] aWithMethodToSkip = default(String[]))
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
                        !stackFrame.GetMethod().DeclaringType.Name.ToString().Equals("_ThreadPoolWaitCallback", StringComparison.CurrentCultureIgnoreCase) &&
                        !skipStackMethod(stackFrame.GetMethod().Name.ToString(), aWithMethodToSkip)

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
                //TracePending.Trace(ex.Message);
                throw (ex);
            }
        }
    }
}
