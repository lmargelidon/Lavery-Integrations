using Lavery.Tools.IO;
using Lavery.Tools.RunTime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools.Runtime
{
    public class TracePending
    {
        static FileStreamSynchronized oFileStream = default(FileStreamSynchronized);
        static Object syncTrace = new Object();



        public static void Trace(String sWithOut, String[] aWithMethodToSkip = default(String[]))
        {
            try
            {
                int iTraceActive = 0;
                try
                {
                    iTraceActive = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TraceUrlActif"]);
                }
                catch
                { }
                if (iTraceActive == 1 && oFileStream == default(FileStreamSynchronized))
                {
                    lock (syncTrace)
                    {
                        if (oFileStream == default(FileStreamSynchronized))
                        {
                            try
                            {
                                String sFilePath = System.Configuration.ConfigurationManager.AppSettings["TraceUrl"];
                                oFileStream = new FileStreamSynchronized(false, sFilePath);
                                oFileStream.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 4000, FileOptions.Asynchronous);
                            }
                            catch
                            { }
                        }
                    }

                }

                if (oFileStream != default(FileStreamSynchronized))
                {
                    try
                    {
                        String SwithClassName = "";
                        String sWithMethodName = "";
                        String sWithAssembly = "";
                        RunTimeClass.getRuntimeInformation(ref sWithAssembly, ref SwithClassName, ref sWithMethodName, aWithMethodToSkip);
                        var taskA = new Task(() =>
                        {
                            lock (syncTrace)
                            {
                                try
                                {
                                    String sBuffer = String.Format("{0}\t{1}\t[{2}].[{3}]\t{4}", DateTime.Now.ToString(), sWithAssembly, SwithClassName, sWithMethodName, sWithOut);
                                    oFileStream.WriteLine(sBuffer, 0, SeekOrigin.End);

                                }
                                catch
                                {
                                }
                            }
                        }
                        );
                        taskA.Start();


                    }
                    catch
                    {

                    }

                }

            }
            catch
            { }

        }
        public static void Trace(String sWithOut, String sWithStackTrace)
        {
            try
            {
                if (oFileStream == default(FileStreamSynchronized))
                {
                    lock (syncTrace)
                    {
                        if (oFileStream == default(FileStreamSynchronized))
                        {
                            try
                            {
                                String sFilePath = System.Configuration.ConfigurationManager.AppSettings["TraceUrl"];
                                oFileStream = new FileStreamSynchronized(false, sFilePath);
                                oFileStream.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 4000, FileOptions.Asynchronous);
                            }
                            catch
                            { }
                        }
                    }

                }

                if (oFileStream != default(FileStreamSynchronized))
                {
                    try
                    {
                        String SwithClassName = "";
                        String sWithMethodName = "";
                        String sWithAssembly = "";
                        RunTimeClass.getRuntimeInformation(ref sWithAssembly, ref SwithClassName, ref sWithMethodName);
                        String sBuffer = String.Format("{0}\t{1}\t{2}", DateTime.Now.ToString(), sWithOut, sWithStackTrace);
                        oFileStream.WriteLine(sBuffer, 0, SeekOrigin.End);

                    }
                    catch
                    {
                    }

                }


            }
            catch
            { }
        }
    }
}
