
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class NxFWKUnit 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  NxFWKUnit()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<System.DateTime> EndDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public byte IsActive { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.Guid NxFWKUnitID { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String SortString { get; set; } 

            public Nullable<System.DateTime> StartDate { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

