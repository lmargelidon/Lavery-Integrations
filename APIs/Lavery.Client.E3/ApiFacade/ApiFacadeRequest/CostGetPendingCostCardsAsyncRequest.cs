
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
    public class CostGetPendingCostCardsAsyncRequest : Object
    {
          [DataMember]
            public DateTime startDate { get; set; }
          [DataMember]
            public DateTime endDate { get; set; }
          [DataMember]
            public List<Guid> costcardID { get; set; }
          [DataMember]
            public Int32 costPeindIndex { get; set; }
          [DataMember]
            public String costType { get; set; }
          [DataMember]
            public Int32 timekeeperIndex { get; set; }
          [DataMember]
            public String timekeeperNumber { get; set; }
          [DataMember]
            public Guid timekeeperID { get; set; }
          [DataMember]
            public Int32 matterIndex { get; set; }
          [DataMember]
            public String matterNumber { get; set; }
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
          [DataMember]
            public CancellationToken cancellationToken { get; set; }

        public void initRequest()
        {
          startDate = default(DateTime);
          endDate = default(DateTime);
          costcardID = default(List<Guid>);
          costPeindIndex = default(Int32);
          costType = default(String);
          timekeeperIndex = default(Int32);
          timekeeperNumber = default(String);
          timekeeperID = default(Guid);
          matterIndex = default(Int32);
          matterNumber = default(String);
          advancedFilterAttributesToInclude = default(List<String>);
          advancedFilterFilterXOQL = default(String);
          advancedFilterFilterPredicates = default(List<E3EAPIQuerySJQLSJPredicate>);
          advancedFilterFilterOperator = default(E3EAPIQuerySJQLSJLogicalOperator);
          advancedFilterFilterGroups = default(List<E3EAPIQuerySJQLSJPredicateGroup>);
          x3ESessionId = default(String);
          x3EUserId = default(String);
          acceptLanguage = default(String);
          cancellationToken = default(CancellationToken);

        }
    }
}

