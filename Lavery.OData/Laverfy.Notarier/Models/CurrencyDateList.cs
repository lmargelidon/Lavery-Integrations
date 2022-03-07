
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class CurrencyDateList : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.String ChrgCurrencyType { get; set; } 

            public System.String ChrgDateMethod { get; set; } 

            public System.String ChrgRoundingMethod { get; set; } 

            public System.String Code { get; set; } 

            public System.String CostCurrencyType { get; set; } 

            public System.String CostDateMethod { get; set; } 

            public System.String CostRoundingMethod { get; set; } 
			[Key]
            public System.Guid CurrencyDateListID { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean Is_Default { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Boolean IsStock { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String SortString { get; set; } 

            public System.String TimeCurrencyType { get; set; } 

            public System.String TimeDateMethod { get; set; } 

            public System.String TimeRoundingMethod { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

