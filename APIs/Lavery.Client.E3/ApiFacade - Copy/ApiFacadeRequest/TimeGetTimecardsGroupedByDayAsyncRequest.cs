
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
    public class TimeGetTimecardsGroupedByDayAsyncRequest : Object
    {
          [DataMember]
            public DateTime startDate { get; set; }
          [DataMember]
            public DateTime endDate { get; set; }
          [DataMember]
            public Int32 lastDays { get; set; }
          [DataMember]
            public Int32 timekeeperIndex { get; set; }
          [DataMember]
            public String timekeeperNumber { get; set; }
          [DataMember]
            public Guid timekeeperID { get; set; }
          [DataMember]
            public Int32 mattIndex { get; set; }
          [DataMember]
            public Int32 clientIndex { get; set; }
          [DataMember]
            public List<String> attributesToInclude { get; set; }
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
          startDate = default(DateTime);
          endDate = default(DateTime);
          lastDays = default(Int32);
          timekeeperIndex = default(Int32);
          timekeeperNumber = default(String);
          timekeeperID = default(Guid);
          mattIndex = default(Int32);
          clientIndex = default(Int32);
          attributesToInclude = default(List<String>);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          cancellationToken = default(CancellationToken);

        }
    }
}

