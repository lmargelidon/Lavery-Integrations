
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class NxCurrencyCode : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.String CurrCode { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Boolean IsReporting { get; set; } 

            public System.Boolean IsStock { get; set; } 

            public System.Boolean IsSupported { get; set; } 

            public System.Guid LastProcItemID { get; set; } 
			[Key]
            public System.Guid NxCurrencyCodeID { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.Int32 Rounding { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public System.String SortString { get; set; } 

            public System.String Symbol { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.String Word { get; set; }
    }
}

