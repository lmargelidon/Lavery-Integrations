using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lavery.Tools
{
   
    public class ReflectionGeneration: Object
    {
        
        ReflectionDataStructures reflectionDS;
        String sNameSpace;

        public ReflectionDataStructures ReflectionDS { get => reflectionDS; set => reflectionDS = value; }

        public ReflectionGeneration(ReflectionDataStructures reflectionDS, String sNameSpace)
        {
            this.ReflectionDS = reflectionDS;
            this.sNameSpace = sNameSpace;
        }
        public StreamWriter initialization( String sFileName)
        {
            return new StreamWriter(sFileName);
        }
        public void GenerateOneRequest(String sPathOfGeneration, ClassRequest oCR)
        {
            String sFileName = sPathOfGeneration + @"\" + oCR.ClassName + ".cs";
            
            if (!Directory.Exists(sPathOfGeneration))
                Directory.CreateDirectory(sPathOfGeneration);

            if (File.Exists(sFileName))
                File.Delete(sFileName);
            using (StreamWriter outputFile = initialization(sFileName))
            {
               
                String sAttributes = "";
                foreach (ParameterInfo oInfo in oCR.Parameters)
                {

                    //Console.WriteLine(oInfo.ParameterType.FullName);
                    String sStripped = oInfo.ParameterType.FullName;
                    sStripped = sStripped.Replace("]", "");
                    sStripped = sStripped.Replace("[", "");
                    sStripped = sStripped.Replace("System.Threading.Tasks.Task`1", "");
                    sStripped = sStripped.Split(',')[0];
                    if (sStripped.StartsWith("System.Collections.Generic.List`1"))
                    {
                        sStripped = sStripped.Replace("System.Collections.Generic.List`1", "");
                        String[] a = sStripped.Split('.');
                        sStripped = String.Format("List<{0}>", a[a.Length - 1]);
                    }
                    else
                    {
                        String[] a = sStripped.Split('.');
                        sStripped = a[a.Length - 1];
                    }
                    string sName = oInfo.Name;
                    if (sName.StartsWith("_"))
                        sName = sName.Substring(1);
                    /*
                    if( sStripped.Equals("DateTime", StringComparison.CurrentCultureIgnoreCase) ||
                        sStripped.Equals("Int32", StringComparison.CurrentCultureIgnoreCase))
                        sAttributes = (String.Format(
 @"{0}          [DataMember]
            public  Nullable<{1}> {2} {{ get; set; }}
", sAttributes, sStripped, sName));
                    else
                    */
                        sAttributes = (String.Format(
 @"{0}          [DataMember]
            public {1} {2} {{ get; set; }}
", sAttributes, sStripped, sName));
                }
                /*
                foreach (ParameterInfo oInfo in oCR.Parameters)
                {

                    //Console.WriteLine(oInfo.ParameterType.FullName);
                    String sStripped = oInfo.ParameterType.FullName;
                    sStripped = sStripped.Replace("]", "");
                    sStripped = sStripped.Replace("[", "");
                    sStripped = sStripped.Replace("System.Threading.Tasks.Task`1", "");
                    sStripped = sStripped.Split(',')[0];
                    if (sStripped.StartsWith("System.Collections.Generic.List`1"))
                    {
                        sStripped = sStripped.Replace("System.Collections.Generic.List`1", "");
                        String[] a = sStripped.Split('.');
                        sStripped = String.Format("List<{0}>", a[a.Length - 1]);
                    }
                    else
                    {
                        String[] a = sStripped.Split('.');
                        sStripped = a[a.Length - 1];
                    }
                    string sName = oInfo.Name;
                    if (sName.StartsWith("_"))
                        sName = sName.Substring(1);
                    char[] strArray = sName.ToCharArray();
                    strArray[0] = char.ToUpper(strArray[0]);                     
                    sAttributes = (String.Format(
 @"{0}       public {1} {3} {{ get => {2}; set => {2} = value; }}
", sAttributes, sStripped, sName, new string(strArray)));
                }
                */
                String sOut = String.Format(ReflectionGenerationTemplates.sClassRequestTemplate, sNameSpace, oCR.ClassName, "Object", sAttributes, GenerateOneRequestInit(oCR));               
                outputFile.WriteLine(sOut);
            }
        }
        public String  GenerateOneRequestInit(ClassRequest oCR)
        {
            
                String sAttributes = "";
                foreach (ParameterInfo oInfo in oCR.Parameters)
                {

                    //Console.WriteLine(oInfo.ParameterType.FullName);
                    String sStripped = oInfo.ParameterType.FullName;
                    sStripped = sStripped.Replace("]", "");
                    sStripped = sStripped.Replace("[", "");
                    sStripped = sStripped.Replace("System.Threading.Tasks.Task`1", "");
                    sStripped = sStripped.Split(',')[0];
                    if (sStripped.StartsWith("System.Collections.Generic.List`1"))
                    {
                        sStripped = sStripped.Replace("System.Collections.Generic.List`1", "");
                        String[] a = sStripped.Split('.');
                        sStripped = String.Format("List<{0}>", a[a.Length - 1]);
                    }
                    else
                    {
                        String[] a = sStripped.Split('.');
                        sStripped = a[a.Length - 1];
                    }
                string sName = oInfo.Name;
                if (sName.StartsWith("_"))
                    sName = sName.Substring(1);
                /*
                if(sStripped.Equals("DateTime", StringComparison.CurrentCultureIgnoreCase))
                    sAttributes = (String.Format(
@"{0}          DateTime ? {2} = null;
", sAttributes, sStripped, sName));
                else
                    if (sStripped.Equals("int32", StringComparison.CurrentCultureIgnoreCase))
                        sAttributes = (String.Format(
@"{0}          Int32 ? {2} = null;
", sAttributes, sStripped, sName));
               */
                else
                    sAttributes = (String.Format(
 @"{0}          {2} = default({1});
", sAttributes, sStripped, sName));
                }

            return sAttributes;
        }
        public void GenerateAllRequest(String sPathOfGeneration)
        {
            foreach (ClassRequest oCR in ReflectionDS.Requests)
                GenerateOneRequest(String.Format(@"{0}\{1}", sPathOfGeneration, "ApiFacadeRequest"), oCR);
        }
        public void codeGederationForOneTypes(String sPathOfGeneration, ClassDetail oClass)
        {
            String sFileName = String.Format(@"{0}\{1}.cs", sPathOfGeneration, oClass.ClassName);

            if (File.Exists(sFileName))
                File.Delete(sFileName);
            using (StreamWriter outputFile = initialization(sFileName))
            {
                String sAllMethods = GenerateMethod(oClass.Members);
                String sOut = String.Format(ReflectionGenerationTemplates.sClassTemplate,
                                                        sNameSpace,
                                                        oClass.ClassName,
                                                        "Object",                                                       
                                                        sAllMethods,
                                                        oClass.ClassName.Replace("Facade",""));
                outputFile.Write(sOut);
            }
        }
        public void codeGederationForAllTypes(String sPathOfGeneration)
        {
            GenerateAllRequest(sPathOfGeneration);

            foreach (ClassDetail t in ReflectionDS.Classes)
            {
                codeGederationForOneTypes(sPathOfGeneration, t);
            }
        }
        public String findParameterName(int iHashing)
        {
            String sRet = "";
            foreach (ClassRequest m in ReflectionDS.Requests)           
                if (m.isMe(iHashing))
                {
                    sRet = m.ClassName;
                    break;
                }

            
            return sRet;
        }
        public String BuildParameters(List<ParameterInfo> parameters, String ObjectName)
        {
            String sRet = "";
            foreach (ParameterInfo m in parameters)
            {
                string sName = m.Name;
                if (sName.StartsWith("_"))
                    sName = sName.Substring(1);
                char[] strArray = sName.ToCharArray();
                // on ne fait pus cela on genere des attributs public
                // avec attribut [DataMember]
                //strArray[0] = char.ToUpper(strArray[0]); 

                sRet += (String.Format("{2} {0}.{1}", ObjectName, new string(strArray), sRet.Length == 0 ? "" : ","));
            }


            return sRet;
        }
        public String GenerateMethod(List<MemberDetail> members)
        {
            String sRet = "";
            foreach (MemberDetail m in members)
            {
                String suffix = "";
                int i = 0;
                String sStripped = ((MethodInfo)m.InformationDetail).ReturnType.FullName;
                sStripped = sStripped.Replace("]", "");
                sStripped = sStripped.Replace("[", "");
                if(sStripped.Contains("System.Threading.Tasks.Task`1"))
                    suffix = ".Result";
                sStripped = sStripped.Replace("System.Threading.Tasks.Task`1", "");
                sStripped = sStripped.Split(',')[0];
                String[] a = sStripped.Split('.');
                
                sRet += String.Format(ReflectionGenerationTemplates.sClassMethodsTemplate,
                                                        a[a.Length - 1],
                                                        m.InformationDetail.Name,
                                                        findParameterName(m.IHashCode), "oClassRequestValue",
                                                        m.InformationDetail.Name,
                                                        BuildParameters(m.Parameters, "oClassRequestValue"),
                                                        suffix);
                
            }
            return sRet;
        }
        public void GenerateMethodParameters(List<ParameterInfo> Parameters, StreamWriter outputFile)
        {
            foreach (ParameterInfo p in Parameters)
            {
                String[] a = p.ParameterType.Name.Split('.');

                String sOut = String.Format("\t\t\t{0} o{1} = default({0});", a[a.Length - 1], p.Name);
                outputFile.WriteLine(sOut);

            }
        }
    }
}
