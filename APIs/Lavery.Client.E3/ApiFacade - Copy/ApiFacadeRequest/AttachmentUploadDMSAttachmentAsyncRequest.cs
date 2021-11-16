
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
    public class AttachmentUploadDMSAttachmentAsyncRequest : Object
    {
          [DataMember]
            public String library { get; set; }
          [DataMember]
            public String documentClass { get; set; }
          [DataMember]
            public String documentType { get; set; }
          [DataMember]
            public String dMSFolder { get; set; }
          [DataMember]
            public Guid parentItemId { get; set; }
          [DataMember]
            public String archetype { get; set; }
          [DataMember]
            public Guid syncMapID { get; set; }
          [DataMember]
            public String subFolder { get; set; }
          [DataMember]
            public String description { get; set; }
          [DataMember]
            public String x3ESessionId { get; set; }
          [DataMember]
            public String x3EUserId { get; set; }
          [DataMember]
            public String acceptLanguage { get; set; }
          [DataMember]
            public CancellationToken cancellationToken { get; set; }

        public void initRequest()
        {
          library = default(String);
          documentClass = default(String);
          documentType = default(String);
          dMSFolder = default(String);
          parentItemId = default(Guid);
          archetype = default(String);
          syncMapID = default(Guid);
          subFolder = default(String);
          description = default(String);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          cancellationToken = default(CancellationToken);

        }
    }
}

