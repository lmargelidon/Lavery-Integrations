
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Timekeeper 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Timekeeper()
        {

        }
 
			[Key]
            public System.Int32 TkprIndex { get; set; } 

            public System.String AltNumber { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> BillDCSTemplate { get; set; } 

            public Nullable<System.Guid> BillGroupDCSTemplate { get; set; } 

            public System.String BillInitial { get; set; } 

            public System.String BillName { get; set; } 

            public Nullable<System.DateTime> CompDate { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public Nullable<System.Guid> CreditNoteDCSTemplate { get; set; } 

            public Nullable<System.Guid> CreditNoteGroupDCSTemplate { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Int32 Entity { get; set; } 

            public Nullable<System.Guid> GLTimekeeper { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public System.String HRNumber { get; set; } 

            public System.String HRTitle { get; set; } 

            public Nullable<System.DateTime> JDDate { get; set; } 

            public Nullable<System.Int32> Language { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String Number { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String PayrollNumber { get; set; } 

            public System.String PhysicalLocation { get; set; } 

            public Nullable<System.Guid> ProfDCSTemplate { get; set; } 

            public Nullable<System.Int32> RateYear { get; set; } 

            public System.String SortName { get; set; } 

            public Nullable<System.Guid> StmtDCSTemplate { get; set; } 

            public System.Guid TimekeeperID { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public System.String TkprAttribute { get; set; } 

            public System.String TkprCategory { get; set; } 

            public System.String TkprStatus { get; set; } 

            public System.String TkprType { get; set; } 

            public System.String WestLawContactIDNum { get; set; } 

            public System.String WestLawUserIDNum { get; set; } 

            public Nullable<System.Guid> WF_User { get; set; }
    }
}

