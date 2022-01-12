using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Laverfy.Wcf.Schemas.Matters
{
    [DataContract]
    public class MattersGet : Object
    {
        [DataMember]
        public List<Guid> matterId { get; set; }
        [DataMember]
        public Int32? mattIndex { get; set; }
        [DataMember]
        public String number { get; set; }
        
        public void initRequest()
        {
            matterId = default(List<Guid>);
            mattIndex = default(Int32);
            number = default(String);            

        }
    }    
}
