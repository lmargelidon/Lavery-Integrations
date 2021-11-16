using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Lavery.Tools.IO
{
    public class FileStreamSynchronized
    {
        Boolean bEchoOff = true;
        
        FileStream fs = default(FileStream);
        String sFileName = "";
        int iIndent = 0;
        Boolean bStreamOpened = false;


        Object syncTrace = new Object();
        Mutex _SynchronizeByNamedMutex;
        String sMutexName = "FileStreamSynchro";
        Boolean bMutexOpened = false;

        
        

        public FileStreamSynchronized(Boolean bWithEchoOff, String sWithFileName)
        {
            try
            {
                bEchoOff = bWithEchoOff;
                sMutexName = sWithFileName.Replace("\\","_").Replace(":","_").Replace(".","_");
                sFileName = sWithFileName;
                lock (syncTrace)
                {
                    
                    _InitializeMutex();
                }
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        
        }

        void _InitializeMutex()
        {
            try
            {
                if (!bMutexOpened)
                {
                    // Try to open existing mutex.
                    _SynchronizeByNamedMutex = Mutex.OpenExisting(sMutexName);
                    if(!bEchoOff)
                        Console.WriteLine("Open existing mutex {0} ok", sMutexName);
                    bMutexOpened = true;
                 
                }
            }
            catch
            {
                if (!bMutexOpened)
                {
                    // If exception occurred, there is no such mutex.
                    _SynchronizeByNamedMutex = new Mutex(false, sMutexName);
                    if (!bEchoOff)
                        Console.WriteLine("Create new mutex {0} ok", sMutexName);
                    bMutexOpened = true;
                }

                // Only one instance.

            }
            // More than one instance.

        }
        public void Open( FileMode eWithFileMode, FileAccess eWithFileAccess, FileShare eWithFileShare, int iWithMaxBufferSize, FileOptions eWithFileOptions)
        {
            try
            {                

                if (!bStreamOpened)
                {
                    try
                    {
                
                        stabilizeWithOneMutex();
                        if (!bStreamOpened)
                        {

                            fs = new FileStream(sFileName, eWithFileMode, eWithFileAccess, eWithFileShare, iWithMaxBufferSize, eWithFileOptions);
                            bStreamOpened = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                    finally
                    {
                        releazeWithOneMutex();
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        public void Close()
        {
            try
            {
                if (bStreamOpened)
                {
                    try
                    {
                        stabilizeWithOneMutex();
                        if (bStreamOpened)
                        {
                            fs.Flush();
                            fs.Close();
                            bStreamOpened = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                    finally
                    {
                        releazeWithOneMutex();
                    }
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        void _Write(byte[] oWithOut, int iWithOffset, SeekOrigin eWithSeekOrigin)
        {
            try
            {
                if (bStreamOpened)
                {
                    try
                    {
                        stabilizeWithOneMutex();
                        
                        fs.Seek(iWithOffset, eWithSeekOrigin);
                        fs.Write(oWithOut, 0, oWithOut.Length);
                        fs.Flush();

                    }
                    catch (Exception ex)
                    {
                        throw (ex);

                    }
                    finally
                    {
                        releazeWithOneMutex();
                    }
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
       
        public void WriteLine(String sWithOut, int iWithOffset, SeekOrigin eWithSeekOrigin)
        {
            try
            {
                byte[] oByte = Encoding.UTF8.GetBytes(String.Format("{0}\r\n", sWithOut));
                _Write(oByte, iWithOffset, eWithSeekOrigin);                

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        public void Write(String sWithOut, int iWithOffset, SeekOrigin eWithSeekOrigin)
        {
            try
            {
                byte[] oByte = Encoding.UTF8.GetBytes(String.Format("{0}", sWithOut));
                _Write(oByte, iWithOffset, eWithSeekOrigin);

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        private void stabilizeWithOneMutex()
        {
            Boolean bOk = false;
            int iLoop = 10;
            while (!bOk)
            {
                try
                {
                    iIndent++;
                    if (!bEchoOff)
                    {
                        for (int i = 0; i < iIndent; i++)
                            Console.Write("\t");
                        Console.Write("Lock Mutex = ");
                    }
                    _SynchronizeByNamedMutex.WaitOne();
                    if (!bEchoOff)
                        Console.WriteLine("Done");

                    bOk = true;
                }
                catch (Exception ex)
                {

                    if (!bEchoOff)
                        Console.Write(" Exception Thrown...");
                    releazeWithOneMutex();
                    if (iLoop <= 0)
                    {
                        if (!bEchoOff)
                            Console.WriteLine("\nMutex Exception raised");
                        throw (ex);
                    }

                }
                iLoop--;
            }
        }
        private void releazeWithOneMutex()
        {
            try
            {

                if (!bEchoOff)
                {
                    for (int i = 0; i < iIndent; i++)
                        Console.Write("\t");
                }
                iIndent--;
                if (!bEchoOff)
                    Console.Write("UnLock Mutex = ");
                _SynchronizeByNamedMutex.ReleaseMutex();
                if (!bEchoOff)
                    Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                if (!bEchoOff)
                    Console.WriteLine("\nMutex Exception raised");
                throw (ex);
            }

        }
    }
}
