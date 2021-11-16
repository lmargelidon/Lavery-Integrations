using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using LsaAspects;

namespace Lavery.Wcf.Api.E3
{
    public class WcfBaseClass:IDisposable
    {
        static int iCountAccess = 0;
        static int iDurationAverage = 0;
        static int iDurationDisposedAverage = 0;
        static Object oSyncObject = new Object();
        Boolean disposed = false;
        //TimingAspect oAspect = TimingAspect.startTimer();
        //TimingAspect oAspectDispose = TimingAspect.startTimer();
        public WcfBaseClass()
        {
            lock (oSyncObject)
            {
                iCountAccess++;

            }
                
        }

        public void stopActivity()
        {
            try 
            {
                lock (oSyncObject)
                {
                    //int iElapse = (int)oAspect.stop();
                    //iDurationAverage = (int)((((iCountAccess - 1) * iDurationAverage) + iElapse) / iCountAccess);
                }
            }
            catch 
            { }
        
        }
          //Implement IDisposable.
        public void Dispose()
        {
            
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    lock (oSyncObject)
                    {
                        //int iElapse = (int)oAspectDispose.stop();
                        //iDurationDisposedAverage = (int)((((iCountAccess - 1) * iDurationDisposedAverage) + iElapse) / iCountAccess);
                    }
                    
                                       
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~WcfBaseClass()
        {
            // Simply call Dispose(false).
            
            Dispose (false);
        }

        public String getServiceInformation()
        {
            String sRet = "";
            try 
            {
                sRet = String.Format("Service Running {0} transaction switched in {1}ms runing averrage time and {2} objects disposing time", iCountAccess, iDurationAverage, iDurationDisposedAverage);
            }
            catch 
            { }
            return sRet;
        }

       
    }
}
