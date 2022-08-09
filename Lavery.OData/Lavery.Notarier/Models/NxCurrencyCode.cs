
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class NxCurrencyCode 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  NxCurrencyCode()
        {

        }
 
			[Key]
            public System.String CurrCode { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public byte IsActive { get; set; } 

            public byte IsReporting { get; set; } 

            public byte IsStock { get; set; } 

            public Nullable<byte> IsSupported { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.Guid NxCurrencyCodeID { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.Int32> Rounding { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public System.String SortString { get; set; } 

            public System.String Symbol { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public System.String Word { get; set; }
    }
}

