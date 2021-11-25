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
        //Assembly oAssembly;       
        //AppDomain oDomain;
        
        assemblyLoaderHelper oLoadderHelper;

        private bool _disposedValue;

        ~ReflectionDataStructures() => Dispose(false);

        public ReflectionDataStructures(Assembly assembly)
        {
            oLoadderHelper.Assembly = assembly;
            aAssemblyReferenced = assembly.GetReferencedAssemblies();
            classes = new List<ClassDetail>();
            requests = new List<ClassRequest>();
            
        }
        public ReflectionDataStructures(String sAsemblyPath, String sAssemblyName)
        {
            try
            {   
                
                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                AppDomain newDomain = AppDomain.CreateDomain(sAssemblyName + "-Domain", AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain  
                System.Runtime.Remoting.ObjectHandle obj = newDomain.CreateInstance(typeof(assemblyLoaderHelper).Assembly.FullName, typeof(assemblyLoaderHelper).FullName);

                oLoadderHelper = (assemblyLoaderHelper)obj.Unwrap();//As the object we are creating is from another appdomain hence we will get that object in wrapped format and hence in the next step we have unwrapped it  
                oLoadderHelper.ODomain = newDomain;
                oLoadderHelper.loadAssembly(sAsemblyPath, sAssemblyName);
                aAssemblyReferenced = oLoadderHelper.Assembly.GetReferencedAssemblies();

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
                    
                    AppDomain.Unload(oLoadderHelper.ODomain);
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


        public Assembly OAssembly { get => oLoadderHelper.Assembly; }
        public List<ClassDetail> Classes { get => classes; }
        public List<ClassRequest> Requests { get => requests; }
        public AssemblyName[] AAssemblyReferenced { get => aAssemblyReferenced; set => aAssemblyReferenced = value; }
        public AppDomain ODomain { get => oLoadderHelper.ODomain; set => oLoadderHelper.ODomain = value; }
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
