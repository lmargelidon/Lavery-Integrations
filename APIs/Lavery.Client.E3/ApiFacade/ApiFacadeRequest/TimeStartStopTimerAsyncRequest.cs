
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
    public class TimeStartStopTimerAsyncRequest : Object
    {
          [DataMember]
            public String x3ESessionId { get; set; }
          [DataMember]
            public String x3EUserId { get; set; }
          [DataMember]
            public String acceptLanguage { get; set; }
          [DataMember]
            public E3EAPITimeModelsStartStopTimerRequest e3EAPITimeModelsStartStopTimerRequest { get; set; }
          [DataMember]
            public CancellationToken cancellationToken { get; set; }

        public void initRequest()
        {
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          e3EAPITimeModelsStartStopTimerRequest = default(E3EAPITimeModelsStartStopTimerRequest);
          cancellationToken = default(CancellationToken);

        }
    }
}

