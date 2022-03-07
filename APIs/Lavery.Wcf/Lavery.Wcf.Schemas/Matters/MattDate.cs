
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Lavery.Wcf.Core
{
     [DataContract]
    public class MattDate : responseBase
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
            public System.Int32 MatterLkUp { get; set; }
            [DataMember]
            public System.DateTime EffStart { get; set; }
            [DataMember]
            public System.String PracticeGroup { get; set; }
            [DataMember]
            public System.String Department { get; set; }
            [DataMember]
            public System.String Section { get; set; }
            [DataMember]
            public System.String Arrangement { get; set; }
            [DataMember]
            public System.String TkprTeam { get; set; }
            [DataMember]
            public System.String ReservesGroup { get; set; }
            [DataMember]
            public System.String PTAGroup { get; set; }
            [DataMember]
            public System.String Office { get; set; }
            [DataMember]
            public System.String MattSplitType { get; set; }
            [DataMember]
            public System.Int32 BillTkpr { get; set; }
            [DataMember]
            public System.Int32 RspTkpr { get; set; }
            [DataMember]
            public System.Int32 SpvTkpr { get; set; }
            [DataMember]
            public System.String PTAGroupCost { get; set; }
            [DataMember]
            public System.String PTAGroupChrg { get; set; }
            [DataMember]
            public System.Boolean IsFireValidation { get; set; }
            [DataMember]
            public System.String PTAGroup2 { get; set; }
            [DataMember]
            public System.String PTAGroupChrg2 { get; set; }
            [DataMember]
            public System.String PTAGroupCost2 { get; set; }
            [DataMember]
            public System.DateTime NxStartDate { get; set; }
            [DataMember]
            public System.String MatterLkUp_Number { get; set; }
            [DataMember]
            public System.String PracticeGroup_Description { get; set; }
            [DataMember]
            public System.String Department_GLDepartment { get; set; }
            [DataMember]
            public System.String Department_GLDepartment_GLValue { get; set; }
            [DataMember]
            public System.String Department_Description { get; set; }
            [DataMember]
            public System.String Section_GLSection { get; set; }
            [DataMember]
            public System.String Section_GLSection_GLValue { get; set; }
            [DataMember]
            public System.String Section_Description { get; set; }
            [DataMember]
            public System.String Arrangement_Description { get; set; }
            [DataMember]
            public System.String TkprTeam_Description { get; set; }
            [DataMember]
            public System.String ReservesGroup_Description { get; set; }
            [DataMember]
            public System.String PTAGroup_Description { get; set; }
            [DataMember]
            public System.String Office_GLOffice { get; set; }
            [DataMember]
            public System.String Office_Unit { get; set; }
            [DataMember]
            public System.String Office_GLOffice_GLValue { get; set; }
            [DataMember]
            public System.String Office_NxUnit_CurrType { get; set; }
            [DataMember]
            public System.String Office_NxUnit_CurrencyType_Description { get; set; }
            [DataMember]
            public System.String Office_NxUnit_Description { get; set; }
            [DataMember]
            public System.String Office_Description { get; set; }
            [DataMember]
            public System.String MattSplitType_Description { get; set; }
            [DataMember]
            public System.String BillTkpr_BillTkprName { get; set; }
            [DataMember]
            public System.String BillTkpr_Number { get; set; }
            [DataMember]
            public System.String RspTkpr_RspTkprName { get; set; }
            [DataMember]
            public System.String RspTkpr_Number { get; set; }
            [DataMember]
            public System.String SpvTkpr_SpvTkprName { get; set; }
            [DataMember]
            public System.String SpvTkpr_Number { get; set; }
            [DataMember]
            public System.String PTAGroupCost_Description { get; set; }
            [DataMember]
            public System.String PTAGroupChrg_Description { get; set; }
            [DataMember]
            public System.String PTAGroup2Rel_Description { get; set; }
            [DataMember]
            public System.String PTAGroupChrg2Rel_Description { get; set; }
            [DataMember]
            public System.String PTAGroupCost2Rel_Description { get; set; }
    }
}

