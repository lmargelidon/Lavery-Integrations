
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Markup 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Markup()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.Guid MarkupID { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

