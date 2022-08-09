
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class MattBudget 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  MattBudget()
        {

        }
 
			[Key]
            public System.Guid MattBudgetID { get; set; } 
			[ForeignKey("LinkMattBudgetAndMatter")]
            public System.Int32 Matter { get; set; } 

            public Matter LinkMattBudgetAndMatter { get; set; } 

            public Nullable<System.Guid> Activity { get; set; } 

            public Nullable<System.Guid> Activity2 { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Decimal> BillAmount { get; set; } 

            public Nullable<System.Decimal> BillHours { get; set; } 

            public Nullable<System.Decimal> BudAmount { get; set; } 

            public Nullable<System.Decimal> BudHours { get; set; } 

            public Nullable<System.Decimal> CollAmount { get; set; } 

            public Nullable<System.Decimal> CollHours { get; set; } 

            public System.String CostType { get; set; } 

            public System.String Currency { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public byte IsActive { get; set; } 

            public byte IsCost { get; set; } 

            public byte IsFee { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public Nullable<System.Decimal> NBAmount { get; set; } 

            public Nullable<System.Decimal> NBHours { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.Guid> Phase { get; set; } 

            public Nullable<System.Guid> Phase2 { get; set; } 

            public System.String PTAGroup { get; set; } 

            public System.String PTAGroup2 { get; set; } 

            public System.String SortString { get; set; } 

            public System.DateTime StartDate { get; set; } 

            public Nullable<System.Guid> Task { get; set; } 

            public Nullable<System.Guid> Task2 { get; set; } 

            public Nullable<System.Int32> Timekeeper { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public Nullable<System.Decimal> WOffAmount { get; set; } 

            public Nullable<System.Decimal> WOffHours { get; set; }
    }
}

