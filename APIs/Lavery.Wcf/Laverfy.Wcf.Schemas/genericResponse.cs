using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lavery.Wcf.Core
{ 

    [DataContract]
    public abstract class genericResponse : Object
    {
        
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

        abstract public void Add(responseBase oBase);
       
    }
}
