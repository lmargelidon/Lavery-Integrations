using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lavery.Wcf.Core
{
    [DataContract]
    public class MattersGetResponse: genericResponse
    {
        [DataMemberAttribute(Name = "responsecollection", EmitDefaultValue = true)]
        public List<MatterGetResponseDetail> ResponseCollection { get; set; }
        public override void Add(responseBase oBase)
        {
            if (ResponseCollection == default(List<MatterGetResponseDetail>))
                ResponseCollection = new List<MatterGetResponseDetail>();
            ResponseCollection.Add((MatterGetResponseDetail)oBase);
        }
    }
}
