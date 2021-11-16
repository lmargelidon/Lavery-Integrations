
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
    public class TimeGetPendingTimecardsRequest : Object
    {
          [DataMember]
            public DateTime startDate { get; set; }
          [DataMember]
            public DateTime endDate { get; set; }
          [DataMember]
            public List<Guid> timeCardPendingID { get; set; }
          [DataMember]
            public Int32 timePendIndex { get; set; }
          [DataMember]
            public Int32 timekeeperIndex { get; set; }
          [DataMember]
            public String timekeeperNumber { get; set; }
          [DataMember]
            public Guid timekeeperID { get; set; }
          [DataMember]
            public List<String> advancedFilterAttributesToInclude { get; set; }
          [DataMember]
            public String advancedFilterFilterXOQL { get; set; }
          [DataMember]
            public List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates { get; set; }
          [DataMember]
            public E3EAPIQuerySJQLSJLogicalOperator advancedFilterFilterOperator { get; set; }
          [DataMember]
            public List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups { get; set; }
          [DataMember]
            public String x3ESessionId { get; set; }
          [DataMember]
            public String x3EUserId { get; set; }
          [DataMember]
            public String acceptLanguage { get; set; }

        public void initRequest()
        {
          startDate = default(DateTime);
          endDate = default(DateTime);
          timeCardPendingID = default(List<Guid>);
          timePendIndex = default(Int32);
          timekeeperIndex = default(Int32);
          timekeeperNumber = default(String);
          timekeeperID = default(Guid);
          advancedFilterAttributesToInclude = default(List<String>);
          advancedFilterFilterXOQL = default(String);
          advancedFilterFilterPredicates = default(List<E3EAPIQuerySJQLSJPredicate>);
          advancedFilterFilterOperator = default(E3EAPIQuerySJQLSJLogicalOperator);
          advancedFilterFilterGroups = default(List<E3EAPIQuerySJQLSJPredicateGroup>);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);

        }
    }
}

