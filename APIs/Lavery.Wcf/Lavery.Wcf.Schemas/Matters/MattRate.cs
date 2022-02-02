
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Lavery.Wcf.Core
{
     [DataContract]
    public class MattRate : responseBase
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
            public System.Int32 Matter { get; set; }
            [DataMember]
            public System.String Rate { get; set; }
            [DataMember]
            public System.Decimal MaxHours { get; set; }
            [DataMember]
            public System.Decimal MaxBillAmt { get; set; }
            [DataMember]
            public System.String Currency { get; set; }
            [DataMember]
            public System.DateTime CurrDate { get; set; }
            [DataMember]
            public System.Boolean IsActive { get; set; }
            [DataMember]
            public System.String RefRate { get; set; }
            [DataMember]
            public System.Guid RateGroup { get; set; }
            [DataMember]
            public System.Decimal MaxFees { get; set; }
            [DataMember]
            public System.Decimal MaxHCo { get; set; }
            [DataMember]
            public System.Decimal MaxSCo { get; set; }
            [DataMember]
            public System.Decimal MaxInt { get; set; }
            [DataMember]
            public System.Decimal MaxBOA { get; set; }
            [DataMember]
            public System.Decimal MaxTax { get; set; }
            [DataMember]
            public System.Decimal MaxOth { get; set; }
            [DataMember]
            public System.Boolean IsEnforceMaximums { get; set; }
            [DataMember]
            public System.String Matter_Number { get; set; }
            [DataMember]
            public System.String Rate_Formula { get; set; }
            [DataMember]
            public System.String Rate_Rate_RateType { get; set; }
            [DataMember]
            public System.String Rate_Rate_IsExceptionRate { get; set; }
            [DataMember]
            public System.String Rate_RateType_RateType_Currency { get; set; }
            [DataMember]
            public System.String Rate_RateType_Description { get; set; }
            [DataMember]
            public System.String Rate_Description { get; set; }
            [DataMember]
            public System.String RefRateRel_Description { get; set; }
            [DataMember]
            public System.String RateGroupRel_Description { get; set; }
    }
}

