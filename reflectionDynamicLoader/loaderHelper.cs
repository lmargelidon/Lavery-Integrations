using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Lavery.Tools
{
    public class _loadedAssembly : Object, IDisposable
    {
        Assembly _assembly;
        AppDomain _domain;
        System.Type MyType;
        object ClassObj;
        Boolean _disposedValue;

        public void loadAssembly(string path, String sAssemblyname)
        {
            AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
            _domain = AppDomain.CreateDomain(sAssemblyname, AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain
            //oDomain.AssemblyResolve += assemblyResolve;
            _assembly = _domain.Load(AssemblyName.GetAssemblyName(path));
        }
        public void unLoadAssembly( )
        {
            AppDomain.Unload(_domain);
            _domain = default(AppDomain);
            _assembly = default(Assembly);
            _disposedValue = true;

        }
        public Boolean isMe(String sAssemblyName)
        {
            String sAssName = _assembly.GetName().Name;
            return _assembly!= default(Assembly) && sAssName.Equals(sAssemblyName, StringComparison.CurrentCultureIgnoreCase);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    unLoadAssembly();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }
        public Boolean ExecuteMethod(string ClassName, String methodName, Object[] args)
        {
            Boolean bRet= false;
            try
            {
                foreach (Type type in _assembly.GetTypes())
                {
                    if (type.IsClass == true)
                    {
                        if (type.FullName.EndsWith("." + ClassName))
                        {
                            MyType = type;
                            // create an instance of the object
                            if (ClassObj == default(Object))
                                ClassObj = Activator.CreateInstance(type);
                            // Dynamically Invoke the method
                            MyType.InvokeMember(methodName,
                              BindingFlags.Default | BindingFlags.InvokeMethod,
                                   null,
                                   ClassObj,
                                   args);
                            bRet = true;

                        }
                    }
                }           
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return bRet;
        }
        public Boolean ExecuteMethod( String methodName, Object[] args)
        {
            Boolean bRet = false;
            try
            {
                if (ClassObj == default(Object))
                    throw(new Exception("Object not created..."));
                // Dynamically Invoke the method
                MyType.InvokeMember(methodName,
                    BindingFlags.Default | BindingFlags.InvokeMethod,
                        null,
                        ClassObj,
                        args);
                bRet = true;
            }
            catch (Exception ex)
            {                
                throw (ex);
            }

            return bRet;
        }
        public Boolean ExecuteConstructor(string ClassName, Object[] args)
        {
            Boolean bRet = false;
            try
            {                
                foreach (Type type in _assembly.GetTypes())
                {
                    if (type.IsClass == true)
                    {
                        if (type.FullName.EndsWith("." + ClassName))
                        {
                            MyType = type;
                            // create an instance of the object
                            ClassObj = Activator.CreateInstance(type, args);
                            bRet = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            return bRet;
        }

    }
    public class loaderHelper: MarshalByRefObject, IDisposable
    {
        private List<_loadedAssembly> _lAassembly= new List<_loadedAssembly>();  
        Boolean _disposedValue;
        public override object InitializeLifetimeService()
        {
            return null;
        }
        public void loadAssembly(string path, String sAssemblyname)
        {
           
            if (!isLoaded(sAssemblyname))
            {
                _loadedAssembly oAss = new _loadedAssembly();
                oAss.loadAssembly(path, sAssemblyname);
                _lAassembly.Add(oAss);
            }
        }
        public Boolean isLoaded(String sAssemblyname)
        {

            return _lAassembly.Count() > 0 ? getAssembly(sAssemblyname) != default(_loadedAssembly) : false;
        }
        public void unLoadAssembly(String sAssemblyname)
        {
            _loadedAssembly oAss = _lAassembly.First(m => m.isMe(sAssemblyname));
            if (oAss != default(_loadedAssembly)) 
            {
                _lAassembly.RemoveAll(m => m.isMe(sAssemblyname));
                oAss.unLoadAssembly();              
            }
        }
        public Boolean ExecuteMethod(String sAssemblyname, string ClassName, String methodName, Object[] args)
        {
            Boolean bRet = false;
           
            _loadedAssembly oAss = getAssembly(sAssemblyname);
            if (oAss != default(_loadedAssembly))
                bRet = oAss.ExecuteMethod(ClassName, methodName, args);
            return bRet;
        }
        public Boolean ExecuteMethod(String sAssemblyname, String methodName, Object[] args)
        {
            Boolean bRet = false;

            _loadedAssembly oAss = getAssembly(sAssemblyname);
            if (oAss != default(_loadedAssembly))
                bRet = oAss.ExecuteMethod(methodName, args);
            return bRet;
        }
        public Object ExecuteConstructor(String sAssemblyname, string ClassName, Object[] args)
        {
            Boolean bRet = false;
            _loadedAssembly oAss = getAssembly(sAssemblyname);
            if (oAss != default(_loadedAssembly))
                bRet = oAss.ExecuteConstructor(ClassName, args);
            return bRet;
        }
        public _loadedAssembly getAssembly(String sAssemblyname)
        {
            _loadedAssembly oAss = default(_loadedAssembly);
            try
            {
                oAss = _lAassembly.First(m => m.isMe(sAssemblyname));
            }
            catch (Exception ex)
            { 

            }

            return oAss;
        }

        /*
        static public Boolean isAssemblyFullyLoaded(String sName, AppDomain oDomain = null)
        {
            Boolean bRet = true;
            Assembly ass = getAsssemblyLoaded(sName, oDomain);
            if (ass == null)
                bRet = false;
            else
            {
                AssemblyName[] aSS = ass.GetReferencedAssemblies();
                foreach (AssemblyName oneAss in aSS)
                    if (getAsssemblyLoaded(oneAss.Name, oDomain) == null)
                    {
                        bRet = false;
                        break;
                    }
            }
            return bRet;
        }
        static public Assembly getAsssemblyLoaded(String sName, AppDomain oDomain = null)
        {
            if (oDomain == null)
                oDomain = AppDomain.CurrentDomain;
            Assembly[] aAss = AppDomain.CurrentDomain.GetAssemblies();
            Assembly oAss = aAss.FirstOrDefault(x => x.FullName.Split(',')[0].Equals(sName, StringComparison.CurrentCultureIgnoreCase));
            return oAss;
        }
        static public Assembly assemblyResolve(object sender, ResolveEventArgs args)
        {
            // Ignore missing resources
            if (args.Name.Contains(".resources"))
                return null;

            Assembly oAssemb = default(Assembly);
            // check for assemblies already loaded
            if ((oAssemb = getAsssemblyLoaded(args.Name)) != null)
                return oAssemb;

            string filename = args.Name.Split(',')[0] + ".dll".ToLower();

            string asmFile = Path.Combine(@".\", filename);

            try
            {
                Assembly AssTemp = System.Reflection.Assembly.LoadFrom(asmFile);
                return AssTemp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        */
        /*
        Assembly assemblyLoaded;
        AppDomain appDomainForLoadAssembly;
        Boolean _disposedValue;

        public Assembly AssemblyLoaded { get => assemblyLoaded;  }       
        public AppDomain AppDomainForLoadAssembly { get => appDomainForLoadAssembly; }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public void loadAssembly(String sAsemblyPath, String sAssemblyName, AppDomain oChildDomain)
        {           
            AppDomainSetup setup = oChildDomain.SetupInformation;
            appDomainForLoadAssembly = AppDomain.CreateDomain("Domain_" + sAssemblyName, oChildDomain.Evidence, setup); //Create an instance of loader class in new appdomain 
            //appDomainForLoadAssembly.AssemblyResolve += ReflectionAssembly.assemblyResolve;
            
            //AssemblyName assemblyName = new AssemblyName();
            //assemblyName.CodeBase = sAsemblyPath;            
            //this.assemblyLoaded = AppDomainForLoadAssembly.Load(assemblyName);
            
            this.assemblyLoaded =  Assembly.Load(AssemblyName.GetAssemblyName(sAsemblyPath));
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        */
        // Protected implementation of Dispose pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }
       
    }
}
