using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Lavery.Tools;


namespace Lavery.Tools
{
    public class MemberDetail : Object
    {
        MemberInfo oInfo;

        List<ParameterInfo> parameters;
        List<MemberInfo> propertyAccessors;
        int iHashCode;
        public MemberDetail(MemberInfo oInfo)
        {
            this.oInfo = oInfo;
            parameters = new List<ParameterInfo>();
            propertyAccessors = new List<MemberInfo>();
        }
        public void addParameterInformatio(ParameterInfo oParameterinfo)
        {
            parameters.Add(oParameterinfo);            
        }
        
        public void computyeHashing()
        {
            String sLine = "";
            foreach (ParameterInfo oPI in parameters)
                sLine += (oPI.ParameterType.Name + oPI.Name);
            iHashCode = LaveryReflection.getHashCode(sLine);
        }

        public MemberInfo InformationDetail { get => oInfo; set => oInfo = value; }
        public List<ParameterInfo> Parameters { get => parameters; set => parameters = value; }
        public List<MemberInfo> PropertyAccessors { get => propertyAccessors; set => propertyAccessors = value; }
        public int IHashCode { get => iHashCode;  }
    }
    public class ClassRequest : Object
    {

        String className;
        List<ParameterInfo> parameters;      
        int iHashCode;
        public ClassRequest(String className, List<ParameterInfo> parameters, int iHashCode)
        {
            this.ClassName = className;
            this.parameters = parameters;
            this.iHashCode = iHashCode;
        }
        public Boolean isMe(int iHashCode)
        {
            return this.iHashCode == iHashCode;
        }
        public string ClassName { get => className; set => className = value; }
        public List<ParameterInfo> Parameters { get => parameters; set => parameters = value; }

       

    }
        public class ClassDetail : Object
    {
        String nameSpace;
        String className;
        List<String> classInheritance;
        List<MemberDetail> members;

        public ClassDetail(String nameSpace, String className)
        {
            this.NameSpace = nameSpace;
            this.ClassName = className;
            ClassInheritance = new List<string>();
            Members = new List<MemberDetail>();
            ClassInheritance.Add("Object");
        }

        public string NameSpace { get => nameSpace; set => nameSpace = value; }
        public string ClassName { get => className; set => className = value; }
        public List<string> ClassInheritance { get => classInheritance; set => classInheritance = value; }
        public List<MemberDetail> Members { get => members; set => members = value; }

        public void addMemberDetail(MemberDetail oMD)
        {
            Members.Add(oMD);
        }
        public void addInheritance(String  sClasseName)
        {
            classInheritance.Add(sClasseName);
        }

    }
    class Loader : MarshalByRefObject
    {
        Assembly assemblyLoaded;

        public Assembly AssemblyLoaded { get => assemblyLoaded;  }
        public override object InitializeLifetimeService()
        {
            return null;
        }
        public void Load(string file)
        {
            assemblyLoaded = Assembly.LoadFile(file);
            // Do stuff with the assembly.
        }
    }
    public class ReflectionDataStructures : IDisposable
    {
        List<ClassDetail> classes;
        List<ClassRequest> requests;
        AssemblyName[] aAssemblyReferenced;
        Assembly oAssembly;
       
        AppDomain oDomain;
        static Object lockObject = new Object();
        static AppDomain oDomainPlugIn;
        static loaderHelper oLoadderHelper;

        private bool _disposedValue;

        ~ReflectionDataStructures() => Dispose(false);

        public ReflectionDataStructures(Assembly assembly)
        {
            this.oAssembly = assembly;
            aAssemblyReferenced = assembly.GetReferencedAssemblies();
            classes = new List<ClassDetail>();
            requests = new List<ClassRequest>();
            
        }
        public ReflectionDataStructures(String sAsemblyPath, String sAssemblyName)
        {
            try
            {
                /*
                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                ODomain = AppDomain.CreateDomain("Domain_" + sAssemblyName, AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain 
                ODomain.AssemblyResolve += ReflectionAssembly.assemblyResolve;

                AssemblyName assemblyName = new AssemblyName();
                assemblyName.CodeBase = sAsemblyPath;            
                this.oAssembly = ODomain.Load(assemblyName); 
                */
                /*
                String sLoader = nameof(Loader) + "-"+ sAssemblyName;
                ODomain = AppDomain.CreateDomain(sLoader, AppDomain.CurrentDomain.Evidence, new AppDomainSetup { ApplicationBase = Path.GetDirectoryName(typeof(Loader).Assembly.Location) });
                var loader = (Loader)ODomain.CreateInstanceAndUnwrap(typeof(Loader).Assembly.FullName, typeof(Loader).FullName);

                String oPath = Path.GetDirectoryName(typeof(Loader).Assembly.Location);
                loader.Load(String.Format(@"{0}\{1}.dll", oPath, sAssemblyName));
                this.oAssembly = loader.AssemblyLoaded;
                */
                
                String sPath1 = String.Format(@"{0}\{1}.dll", Path.GetDirectoryName(typeof(Loader).Assembly.Location), "reflectionDynamicLoader");
                String sPath2 = String.Format(@"{0}\{1}.dll", Path.GetDirectoryName(typeof(Loader).Assembly.Location), sAssemblyName);
                //AppDomain domain = AppDomain.CreateDomain("PluginDomain");
                
                lock (lockObject)
                {
                    if (oDomainPlugIn == null)
                        oDomainPlugIn = AppDomain.CreateDomain("PluginDomain");
                } 
                
                /*
                oDomain = AppDomain.CreateDomain(sAssemblyName);
                
                */

                //AssemblyName assemblyName = new AssemblyName();
                //assemblyName.CodeBase = sPath1;
                //oDomain.Load(assemblyName);
                //Boolean bRet = ReflectionAssembly.isAssemblyFullyLoaded( "reflectionDynamicLoader", oDomain);
               /*
                oLoadderHelper = (loaderHelper)oDomainPlugIn.CreateInstanceAndUnwrap(typeof(loaderHelper).Assembly.FullName, typeof(loaderHelper).FullName);
                oLoadderHelper.loadAssembly(sPath2, "sAssemblyName", oDomainPlugIn);

                this.oAssembly = oLoadderHelper.AssemblyLoaded;
                this.oDomain = oLoadderHelper.AppDomainForLoadAssembly;
                this.oDomain.AssemblyResolve += ReflectionAssembly.assemblyResolve;
               */
                
                aAssemblyReferenced = oAssembly.GetReferencedAssemblies();

                classes = new List<ClassDetail>();
                requests = new List<ClassRequest>();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
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
                    
                    AppDomain.Unload(oDomain);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }
        public void addClasse(ClassDetail classDetail)
        {
            classes.Add(classDetail);

            Boolean bfound = false;

            foreach (MemberDetail oCD in classDetail.Members)
            {
                bfound = false;
                foreach (ClassRequest oCR in Requests)
                    if (oCR.isMe(oCD.IHashCode))
                    {
                        bfound = true;
                        break;
                    }
                if (!bfound)                
                    Requests.Add(new ClassRequest(oCD.InformationDetail.Name + "Request", oCD.Parameters, oCD.IHashCode));
                 
            }                
        }


        public Assembly OAssembly { get => oAssembly; }
        public List<ClassDetail> Classes { get => classes; }
        public List<ClassRequest> Requests { get => requests; }
        public AssemblyName[] AAssemblyReferenced { get => aAssemblyReferenced; set => aAssemblyReferenced = value; }
        public AppDomain ODomain { get => oDomain; set => oDomain = value; }
    }
    class LoadeMyAssembly : MarshalByRefObject
    {
        private Assembly _assembly;
        System.Type MyType = null;
        object inst = null;

        public Assembly Assembly { get => _assembly; }

        public override object InitializeLifetimeService()
        {
            return null;
        }
        public void LoadAssembly(string path)
        {
            _assembly = Assembly.Load(AssemblyName.GetAssemblyName(path));
        }       
    }
}
