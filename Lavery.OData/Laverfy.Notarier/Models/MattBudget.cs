
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class MattBudget : Object
    {
 

            public System.Guid Activity { get; set; } 

            public System.Guid Activity2 { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Decimal BillAmount { get; set; } 

            public System.Decimal BillHours { get; set; } 

            public System.Decimal BudAmount { get; set; } 

            public System.Decimal BudHours { get; set; } 

            public System.Decimal CollAmount { get; set; } 

            public System.Decimal CollHours { get; set; } 

            public System.String CostType { get; set; } 

            public System.String Currency { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Boolean IsCost { get; set; } 

            public System.Boolean IsFee { get; set; } 

            public System.Guid LastProcItemID { get; set; } 
			[Key]
            public System.Guid MattBudgetID { get; set; } 

            public System.Decimal NBAmount { get; set; } 

            public System.Decimal NBHours { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.Guid Phase { get; set; } 

            public System.Guid Phase2 { get; set; } 

            public System.String PTAGroup { get; set; } 

            public System.String PTAGroup2 { get; set; } 

            public System.String SortString { get; set; } 

            public System.DateTime StartDate { get; set; } 

            public System.Guid Task { get; set; } 

            public System.Guid Task2 { get; set; } 

            public System.Int32 Timekeeper { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.Decimal WOffAmount { get; set; } 

            public System.Decimal WOffHours { get; set; }
    }
}

