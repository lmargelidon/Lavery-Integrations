using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//using Lavery.Listeners;



namespace Lavery.Tools
{
    public class assemblyLoaderHelper : MarshalByRefObject, IDisposable
    {
        Assembly _assembly;
        AppDomain oDomain;
        System.Type MyType;
        object oClassInstance;
        Boolean _disposedValue;

        public AppDomain ODomain { get => oDomain; set => oDomain = value; }
        public Assembly Assembly { get => _assembly; set => _assembly = value; }
        public object OClassInstance { get => oClassInstance;  }

        public void loadAssembly(string path, String sAssemblyname)
        {
            try
            {
                Assembly = Assembly.Load(AssemblyName.GetAssemblyName(path));
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        
        public Boolean isMe(String sAssemblyName)
        {
            String sAssName = Assembly.GetName().Name;
            return Assembly != default(Assembly) && sAssName.Equals(sAssemblyName, StringComparison.CurrentCultureIgnoreCase);
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
                    Assembly = default(Assembly);
                    MyType = default(Type);
                    MyType.InvokeMember("Dispose",
                                  BindingFlags.Default | BindingFlags.InvokeMethod,
                                       null,
                                       oClassInstance,
                                       null);
                    oClassInstance = default(Object);
                }              
                
                _disposedValue = true;
            }
        }
        public Boolean ExecuteMethod(string ClassName, String methodName, Object[] args)
        {
            Boolean bRet = false;
            try
            {
                foreach (Type type in Assembly.GetTypes())
                {
                    if (type.IsClass == true)
                    {
                        if (type.FullName.EndsWith("." + ClassName))
                        {
                            
                            MyType = type;
                            // create an instance of the object
                            if (oClassInstance == default(Object))
                                oClassInstance = Activator.CreateInstance(type);
                            // Dynamically Invoke the method
                            MyType.InvokeMember(methodName,
                                BindingFlags.Default | BindingFlags.InvokeMethod,
                                    null,
                                    oClassInstance,
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
        public Boolean ExecuteMethod(String methodName, Object[] args)
        {
            Boolean bRet = false;
            try
            {
                if (oClassInstance == default(Object))
                    throw (new Exception("Object not created..."));
                // Dynamically Invoke the method
                MyType.InvokeMember(methodName,
                    BindingFlags.Default | BindingFlags.InvokeMethod,
                        null,
                        oClassInstance,
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
                foreach (Type type in Assembly.GetTypes())
                {
                    if (type.IsClass == true)
                    {
                        if (type.FullName.EndsWith("." + ClassName))
                        {
                            MyType = type;
                            // create an instance of the object
                            oClassInstance = Activator.CreateInstance(type, args);
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

    }
    
}
