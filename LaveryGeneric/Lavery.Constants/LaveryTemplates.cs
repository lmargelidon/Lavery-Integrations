using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Constants
{
    public class LaveryTemplates
    {
        static public String sClasseTemplate = @"
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace {0}
{{
     [DataContract]
    public class {1} : Object
    {{
{2}
    }}
}}
";
        static public String sAttributesTemplate = @"
            [DataMember]
            public {0} {1} {{ get; set; }}";

    }
}

