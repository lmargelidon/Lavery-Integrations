using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools
{

    public class SynchronizeGlobalInstance : IDisposable
    {
        
        public bool _hasHandle = false;
        Mutex _mutex;

        private void InitMutex(string appMutextName)
        {
            //string appMutextName = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value;
            string mutexId = string.Format("Global\\{{{0}}}", appMutextName);
            _mutex = new Mutex(false, mutexId);

            var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
            var securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);
            _mutex.SetAccessControl(securitySettings);
        }

        public SynchronizeGlobalInstance(int timeOut, string appMutextName)
        {
            InitMutex(appMutextName);
            try
            {
                if (timeOut < 0)
                    _hasHandle = _mutex.WaitOne(Timeout.Infinite, false);
                else
                    _hasHandle = _mutex.WaitOne(timeOut, false);

                if (_hasHandle == false)
                    throw new TimeoutException("Timeout waiting for exclusive access on SingleInstance");
            }
            catch (AbandonedMutexException)
            {
                _hasHandle = true;
            }
        }


        public void Dispose()
        {
            if (_mutex != null)
            {
                if (_hasHandle)
                    _mutex.ReleaseMutex();
                _mutex.Close();
            }
        }
    }
}