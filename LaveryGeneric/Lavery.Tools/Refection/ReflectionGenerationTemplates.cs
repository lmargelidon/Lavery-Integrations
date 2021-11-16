using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools
{
    class ReflectionGenerationTemplates
    {
        static public String sClassTemplate =
@"
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;

using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace {0}
{{
    [DataContract]
    public class {1} : {2}
    {{
        {4} oApi  {{get;set;}}
        connectionFactory oConnectionFactory;
        public {1}(connectionFactory oConnectionFactory)
        {{
            this.oConnectionFactory = oConnectionFactory;
            oApi = new {4}(oConnectionFactory.ConnectionString(""ConnectionE3RestApi"")); 
            if(oConnectionFactory.getKeyValueString(""E3RestApi-Authentification"").Equals(""NTLM"", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }}
{3}
    }}
}}";
        static public  String sClassRequestTemplate =
@"
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;

using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace {0}
{{   
    [DataContract]
    public class {1} : {2}
    {{
{3}
        public void initRequest()
        {{
{4}
        }}
    }}
}}
";
        static public String sClassMethodsTemplate =
 @"     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method {1}
            returning {0} class response modele
            ----------------------------------------------------------------
        */
        public {0} {1}({2} {3})
        {{
            {0} oRet = default({0});
            try
            {{
                oRet = oApi.{4}({5}){6};
            }}
            catch(Exception ex)
            {{
                Console.WriteLine(ex.Message);
                throw(ex);
            }}
            return oRet;
        }}";
        
    }
}
