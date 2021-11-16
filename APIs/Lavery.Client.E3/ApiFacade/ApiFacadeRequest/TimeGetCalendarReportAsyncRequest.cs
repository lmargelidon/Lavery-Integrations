
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
    public class TimeGetCalendarReportAsyncRequest : Object
    {
          [DataMember]
            public Int32 timekeeper { get; set; }
          [DataMember]
            public DateTime startDate { get; set; }
          [DataMember]
            public DateTime endDate { get; set; }
          [DataMember]
            public Int32 matter { get; set; }
          [DataMember]
            public Int32 client { get; set; }
          [DataMember]
            public Boolean includeHours { get; set; }
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
          timekeeper = default(Int32);
          startDate = default(DateTime);
          endDate = default(DateTime);
          matter = default(Int32);
          includeHours = default(Boolean);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          cancellationToken = default(CancellationToken);

        }
    }
}

