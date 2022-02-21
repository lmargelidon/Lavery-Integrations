
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Timekeeper : Object
    {
 

            public System.String AltNumber { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Guid BillDCSTemplate { get; set; } 

            public System.Guid BillGroupDCSTemplate { get; set; } 

            public System.String BillInitial { get; set; } 

            public System.String BillName { get; set; } 

            public System.DateTime CompDate { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.Guid CreditNoteDCSTemplate { get; set; } 

            public System.Guid CreditNoteGroupDCSTemplate { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Int32 Entity { get; set; } 

            public System.Guid GLTimekeeper { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String HRNumber { get; set; } 

            public System.String HRTitle { get; set; } 

            public System.DateTime JDDate { get; set; } 

            public System.Int32 Language { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String Number { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String PayrollNumber { get; set; } 

            public System.String PhysicalLocation { get; set; } 

            public System.Guid ProfDCSTemplate { get; set; } 

            public System.Int32 RateYear { get; set; } 

            public System.String SortName { get; set; } 

            public System.Guid StmtDCSTemplate { get; set; } 
			[Key]
            public System.Guid TimekeeperID { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.String TkprAttribute { get; set; } 

            public System.String TkprCategory { get; set; } 

            public System.Int32 TkprIndex { get; set; } 

            public System.String TkprStatus { get; set; } 

            public System.String TkprType { get; set; } 

            public System.String WestLawContactIDNum { get; set; } 

            public System.String WestLawUserIDNum { get; set; } 

            public System.Guid WF_User { get; set; }
    }
}

