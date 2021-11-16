
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

namespace Lavery.Client.E3
{   
    [DataContract]
    public class AttachmentGetAttachmentsRequest : Object
    {
          [DataMember]
            public List<String> parentItemIds { get; set; }
          [DataMember]
            public String archetype { get; set; }
          [DataMember]
            public String x3ESessionId { get; set; }
          [DataMember]
            public String x3EUserId { get; set; }
          [DataMember]
            public String acceptLanguage { get; set; }

        public void initRequest()
        {
          parentItemIds = default(List<String>);
          archetype = default(String);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);

        }
    }
}

