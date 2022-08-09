
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class InvoiceOverride 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  InvoiceOverride()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public System.Guid InvoiceOverrideID { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String NextCRNoteNumber { get; set; } 

            public System.String NextCRTaxInvNumber { get; set; } 

            public System.String NextInvNumber { get; set; } 

            public System.String NextTaxInvNumber { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

