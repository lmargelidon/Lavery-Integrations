
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Lavery.Wcf.Core
{
     [DataContract]
    public class RateExcDet : responseBase
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
            public System.Guid RateExc { get; set; }
            [DataMember]
            public System.Decimal RateOverride { get; set; }
            [DataMember]
            public System.String Rate { get; set; }
            [DataMember]
            public System.Decimal MaxRate { get; set; }
            [DataMember]
            public System.String Currency { get; set; }
            [DataMember]
            public System.DateTime CurrencyDate { get; set; }
            [DataMember]
            public System.Int32 Timekeeper { get; set; }
            [DataMember]
            public System.String Title { get; set; }
            [DataMember]
            public System.String Office { get; set; }
            [DataMember]
            public System.String Section { get; set; }
            [DataMember]
            public System.String RateClass { get; set; }
            [DataMember]
            public System.String Description { get; set; }
            [DataMember]
            public System.String Department { get; set; }
            [DataMember]
            public System.String CostType { get; set; }
            [DataMember]
            public System.DateTime Startdate { get; set; }
            [DataMember]
            public System.DateTime FinishDate { get; set; }
            [DataMember]
            public System.Decimal OverridePercent { get; set; }
            [DataMember]
            public System.String RoundingMethod { get; set; }
            [DataMember]
            public System.Int32 RateYearRangeMin { get; set; }
            [DataMember]
            public System.Int32 RateYearRangeMax { get; set; }
            [DataMember]
            public System.Decimal MatterRateMax { get; set; }
            [DataMember]
            public System.Int32 MultiDimensionOrdinal { get; set; }
            [DataMember]
            public System.Decimal MatterRateMin { get; set; }
            [DataMember]
            public System.Decimal DeviationAmount { get; set; }
            [DataMember]
            public System.String RateExc_Description { get; set; }
            [DataMember]
            public System.String Rate_RateFormula { get; set; }
            [DataMember]
            public System.String Rate_RateIsActive { get; set; }
            [DataMember]
            public System.Boolean Rate_IsExceptionRate { get; set; }
            [DataMember]
            public System.String Rate_Description { get; set; }
            [DataMember]
            public System.String Timekeeper_TkprDispName { get; set; }
            [DataMember]
            public System.String Timekeeper_Number { get; set; }
            [DataMember]
            public System.String Title_TitleDesc { get; set; }
            [DataMember]
            public System.String Office_OfficeDesc { get; set; }
            [DataMember]
            public System.String Section_SectionDesc { get; set; }
            [DataMember]
            public System.String RateClass_RateClassDesc { get; set; }
            [DataMember]
            public System.String Department_DepartmentDesc { get; set; }
            [DataMember]
            public System.String CostTypeRel_Description { get; set; }
            [DataMember]
            public System.String CostTypeRel_Code { get; set; }
            [DataMember]
            public System.String RoundingMethodRel_Description { get; set; }
    }
}

