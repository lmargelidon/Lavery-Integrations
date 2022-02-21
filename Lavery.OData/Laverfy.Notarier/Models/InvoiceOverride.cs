
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class InvoiceOverride : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.String Code { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean HasAttachments { get; set; } 
			[Key]
            public System.Guid InvoiceOverrideID { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String NextCRNoteNumber { get; set; } 

            public System.String NextCRTaxInvNumber { get; set; } 

            public System.String NextInvNumber { get; set; } 

            public System.String NextTaxInvNumber { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

