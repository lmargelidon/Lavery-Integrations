
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
    public class TimeGetTimeCaptureAllCardsAsyncRequest : Object
    {
          [DataMember]
            public Int32 index { get; set; }
          [DataMember]
            public DateTime startDate { get; set; }
          [DataMember]
            public DateTime endDate { get; set; }
          [DataMember]
            public Int32 timekeeperIndex { get; set; }
          [DataMember]
            public String timekeeperNumber { get; set; }
          [DataMember]
            public Guid timekeeperID { get; set; }
          [DataMember]
            public List<Guid> itemIds { get; set; }
          [DataMember]
            public List<String> attributesToInclude { get; set; }
          [DataMember]
            public String filterXOQL { get; set; }
          [DataMember]
            public List<E3EAPIQuerySJQLSJPredicate> filterPredicates { get; set; }
          [DataMember]
            public E3EAPIQuerySJQLSJLogicalOperator filterOperator { get; set; }
          [DataMember]
            public List<E3EAPIQuerySJQLSJPredicateGroup> filterGroups { get; set; }
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
          index = default(Int32);
          startDate = default(DateTime);
          endDate = default(DateTime);
          timekeeperIndex = default(Int32);
          timekeeperNumber = default(String);
          timekeeperID = default(Guid);
          itemIds = default(List<Guid>);
          attributesToInclude = default(List<String>);
          filterXOQL = default(String);
          filterPredicates = default(List<E3EAPIQuerySJQLSJPredicate>);
          filterOperator = default(E3EAPIQuerySJQLSJLogicalOperator);
          filterGroups = default(List<E3EAPIQuerySJQLSJPredicateGroup>);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          cancellationToken = default(CancellationToken);

        }
    }
}

