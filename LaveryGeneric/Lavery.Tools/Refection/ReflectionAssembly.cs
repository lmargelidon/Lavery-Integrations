using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lavery.Tools
{
    public enum MemberType { All, Methods, Preoperties}

    
    public class ReflectionAssembly : Object
    {
        ReflectionDataStructures reflectionDS;

        public ReflectionDataStructures ReflectionDS { get => reflectionDS; }
        public ReflectionAssembly()
        {            

        }
        public void loadAssembly(String sFullPathAssemblyName)
        {
            try
            {
                reflectionDS = new ReflectionDataStructures(Assembly.LoadFile(sFullPathAssemblyName));
                foreach (Type t in getExportedClass(false, new List<String> { "Elite" }, new List<String> { "Api" }))
                {
                    ClassDetail oCD = new ClassDetail("Lavery.Client.E3", t.Name + "Facade");

                    foreach (MemberDetail m in getProperties(t, MemberType.Methods))
                    {
                        m.computyeHashing();
                        oCD.addMemberDetail(m);
                    }
                    reflectionDS.addClasse(oCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ReflectionAssembly(String sAssemblyPath, String sAssemblyName)
        {
            try
            {

                //reflectionDS = new ReflectionDataStructures(Assembly.LoadFrom(sAssemblyName));

                reflectionDS = new ReflectionDataStructures(sAssemblyPath, sAssemblyName); //essayer avec dedicated appdomain

                foreach (Type t in getExportedClass(false, new List<String> { "Elite" }, new List<String> { "Api" }))
                {
                    ClassDetail oCD = new ClassDetail("Lavery.Client.E3", t.Name + "Facade");
                    
                    foreach (MemberDetail m in getProperties(t, MemberType.Methods))
                    {
                        m.computyeHashing();
                        oCD.addMemberDetail(m);
                    }
                    ReflectionDS.addClasse(oCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ReflectionAssembly(Assembly assemblyToLoad)
        {
            try
            {
                reflectionDS = new ReflectionDataStructures(assemblyToLoad);
                foreach (Type t in getExportedClass(false, new List<String> { "Elite" }, new List<String> { "Api" }))
                {
                    ClassDetail oCD = new ClassDetail("Lavery.Client.E3", t.Name + "Facade");

                    foreach (MemberDetail m in getProperties(t, MemberType.Methods))
                    {
                        m.computyeHashing();
                        oCD.addMemberDetail(m);
                    }
                    ReflectionDS.addClasse(oCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ReflectionAssembly(Type oType)
        {
            try
            {
                reflectionDS = new ReflectionDataStructures(Assembly.GetAssembly(oType));
                foreach (Type t in getExportedClass(false, new List<String> { "Elite" }, new List<String> { "Api" }))
                {
                    ClassDetail oCD = new ClassDetail("Lavery.Client.E3", t.Name + "Facade");

                    foreach (MemberDetail m in getProperties(t, MemberType.Methods))
                    {
                        m.computyeHashing();
                        oCD.addMemberDetail(m);
                    }
                    ReflectionDS.addClasse(oCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        static public ReflectionAssembly ReflectionBuilder(String sPathOfAssembly, String sAssemblyName)
        {

            ReflectionAssembly oReflection = new ReflectionAssembly(sPathOfAssembly, sAssemblyName);

            return oReflection;
        }
        static public Boolean isAssemblyFullyLoaded(String sName, AppDomain oDomain = null)
        {
            Boolean bRet = true;
            Assembly ass = getAssemblyLoaded(sName, oDomain);
            if (ass == null)
                bRet = false;
            else
            {
                AssemblyName[] aSS = ass.GetReferencedAssemblies();
                foreach (AssemblyName oneAss in aSS)
                    if (getAssemblyLoaded(oneAss.Name, oDomain) == null)
                    {
                        bRet = false;
                        break;
                    }
            }
            return bRet;
        }
        static public Assembly getAssemblyLoaded(String sName, AppDomain oDomain = null)
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
            if ((oAssemb = getAssemblyLoaded(args.Name)) != null)
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

        public void GenerateTypes(String sPathOfGeneration, String sNameSpace)
        {

            ReflectionGeneration oReflectionGeneration = new ReflectionGeneration(ReflectionDS, sNameSpace);
            oReflectionGeneration.codeGederationForAllTypes(sPathOfGeneration);
        }
        
        public List<Module> getModules()
        {
            List<Module> lModule = new List<Module>();

            foreach (Module m in ReflectionDS.OAssembly.GetModules(true))
                lModule.Add(m);

            return lModule;

        }
        public List<Type> getExportedClass(Boolean bInsertInterface, List<String> excludedClasses, List<String> includedClassesEndingBy)
        {
            List<Type> Classes = new List<Type>();

            foreach (Type m in ReflectionDS.OAssembly.GetExportedTypes())
            {
                Boolean bIncluded = true;
                if (m.IsInterface && !bInsertInterface)
                    continue;
               

                foreach (String s in excludedClasses)
                    if (m.Name.Equals(s, StringComparison.CurrentCultureIgnoreCase))
                    {
                        bIncluded = false;
                        break;
                    }

                if (bIncluded)
                {
                    foreach (String s in includedClassesEndingBy)
                        if (!m.Name.EndsWith(s))
                        {
                            bIncluded = false;
                            break;
                        }
                }
                if (bIncluded)
                    Classes.Add(m);
            }

            return Classes;

        }
        public Type GetType(String includedClasses)
        {
            Type Classe = default(Type);

            foreach (Type m in ReflectionDS.OAssembly.GetExportedTypes())
            {
                if(m.Name.Equals(includedClasses, StringComparison.CurrentCultureIgnoreCase))
                {
                    Classe = m;
                    break;
                }                
            }

            return Classe;

        }
        public List<MemberDetail> getProperties(Type oType, MemberType eMemberType)
        {
            List<MemberDetail> Members = new List<MemberDetail>();

            foreach (MemberInfo mi in oType.GetMembers())
            {
                if (mi.Name.StartsWith("get", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("set", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("add", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("default", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("Equals", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith(".ctor", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("toString", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("configuration", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.StartsWith("Exception", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.EndsWith("WithHttpInfoAsync", StringComparison.CurrentCultureIgnoreCase) ||
                    mi.Name.EndsWith("WithHttpInfo", StringComparison.CurrentCultureIgnoreCase))
                    continue;    
                MemberDetail oMemberDetail = new MemberDetail(mi);
                Members.Add(oMemberDetail);
               
                if (mi.MemberType == MemberTypes.Method && (eMemberType == MemberType.Methods || eMemberType == MemberType.All))                     
                    foreach (ParameterInfo pi in ((MethodInfo)mi).GetParameters())                        
                        oMemberDetail.Parameters.Add(pi);

                

                // If the member is a property, display information about the property's accessor methods.
                if (mi.MemberType == MemberTypes.Property && eMemberType == MemberType.Preoperties)               
                    foreach (MethodInfo am in ((PropertyInfo)mi).GetAccessors())
                        oMemberDetail.PropertyAccessors.Add(am);
            }
             
            return Members;
        }
        /*
        public AssemblyName GetReferencedAssemblyInformation(String sWithName)
        {

            Assembly aBase = typeof(ReflectionAssembly).Assembly;

            foreach (AssemblyName an in aBase.GetReferencedAssemblies())
            {
                if ()
                    Display(indent + 1, "Name={0}, Version={1}, Culture={2}, PublicKey token={3}", an.Name, an.Version, an.CultureInfo.Name, (BitConverter.ToString(an.GetPublicKeyToken())));
            }
        }
        */
    }
}
