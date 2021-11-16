
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
    public class RelatedPartyGetRelatedPartiesAsyncRequest : Object
    {
          [DataMember]
            public List<Guid> relatedPartyId { get; set; }
          [DataMember]
            public Int32 relatedPartyIndex { get; set; }
          [DataMember]
            public List<String> advancedFilterChildObjectsToInclude { get; set; }
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
          relatedPartyId = default(List<Guid>);
          relatedPartyIndex = default(Int32);
          advancedFilterChildObjectsToInclude = default(List<String>);
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

