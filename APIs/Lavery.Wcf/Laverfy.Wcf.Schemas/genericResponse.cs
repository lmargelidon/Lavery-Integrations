using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Laverfy.Wcf.Schemas
{ 

    [DataContract]
    public class genericResponse : Object
    {
        [DataMemberAttribute(Name = "response", EmitDefaultValue = true)]
        public String Response  { get; set; }

        [DataMemberAttribute(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary <String, KeyValuePair<String, Type>> Attributes { get; set; }
        //
        // Summary:
        //     Gets or Sets Success
        [DataMemberAttribute(Name = "success", EmitDefaultValue = false)]
        public bool Success { get; set; }
        //
        // Summary:
        //     Gets or Sets Message
        [DataMemberAttribute(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }
    }
}
