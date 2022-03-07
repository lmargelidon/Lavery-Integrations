
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Lavery.Wcf.Core
{
     [DataContract]
    public class RateExc : responseBase
    {

            [DataMember]
            public System.Guid ItemID { get; set; }
            [DataMember]
            public System.String ArchetypeCode { get; set; }
            [DataMember]
            public System.Guid CurrProcItemID { get; set; }
            [DataMember]
            public System.Guid LastProcItemID { get; set; }
            [DataMember]
            public System.Guid OrigProcItemID { get; set; }
            [DataMember]
            public System.Boolean HasAttachments { get; set; }
            [DataMember]
            public System.DateTime TimeStamp { get; set; }
            [DataMember]
            public System.String Description { get; set; }
            [DataMember]
            public System.Int32 Client { get; set; }
            [DataMember]
            public System.Int32 Matter { get; set; }
            [DataMember]
            public System.DateTime StartDate { get; set; }
            [DataMember]
            public System.DateTime FinishDate { get; set; }
            [DataMember]
            public System.String Currency { get; set; }
            [DataMember]
            public System.String RateExcList { get; set; }
            [DataMember]
            public System.Boolean IsMaximum { get; set; }
            [DataMember]
            public System.Boolean IsValidate { get; set; }
            [DataMember]
            public System.Boolean IsMatchCurr { get; set; }
            [DataMember]
            public System.DateTime OverrideDate { get; set; }
            [DataMember]
            public System.Boolean IsSkipClientExc { get; set; }
            [DataMember]
            public System.String CostType { get; set; }
            [DataMember]
            public System.Int32 MultiDimensionOrdinal { get; set; }
            [DataMember]
            public System.Boolean IsStdRateExc { get; set; }
            [DataMember]
            public System.String Client_Number { get; set; }
            [DataMember]
            public System.String Matter_Number { get; set; }
            [DataMember]
            public System.String RateExcList_ExcListOrdinal { get; set; }
            [DataMember]
            public System.String RateExcList_ExcListDesc { get; set; }
            [DataMember]
            public System.String RateExcList_Code { get; set; }
            [DataMember]
            public System.String RateExcList_Description { get; set; }
            [DataMember]
            public System.String CostTypeRel_Code { get; set; }
            [DataMember]
            public System.String CostTypeRel_Description { get; set; }
            [DataMember]
            public List<RateExcDet> LRateExcDet { get; set; }
    }
}

