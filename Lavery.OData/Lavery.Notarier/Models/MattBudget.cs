
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class MattBudget : Object
    {
 

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

            public Nullable<System.Boolean> HasAttachments { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Boolean IsCost { get; set; } 

            public System.Boolean IsFee { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 
			[Key]
            public System.Guid MattBudgetID { get; set; } 

            public Matter Matter { get; set; } 

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

