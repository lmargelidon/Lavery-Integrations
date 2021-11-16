using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lavery.Tools
{
    public class loaderHelper: MarshalByRefObject, IDisposable
    {
        Assembly assemblyLoaded;
        AppDomain appDomainForLoadAssembly;
        Boolean _disposedValue;

        public Assembly AssemblyLoaded { get => assemblyLoaded;  }

        public void loadAssembly(String sAsemblyPath, String sAssemblyName)
        {           
            AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
            appDomainForLoadAssembly = AppDomain.CreateDomain("Domain_" + sAssemblyName, AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain 
            //appDomainForLoadAssembly.AssemblyResolve += ReflectionAssembly.assemblyResolve;

            AssemblyName assemblyName = new AssemblyName();
            assemblyName.CodeBase = sAsemblyPath;            
            this.assemblyLoaded = appDomainForLoadAssembly.Load(assemblyName);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    AppDomain.Unload(appDomainForLoadAssembly);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }
       
    }
}
