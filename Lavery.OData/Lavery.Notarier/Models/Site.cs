
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Site 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Site()
        {

        }
 
			[Key]
            public System.Int32 SiteIndex { get; set; } 

            public Nullable<System.Int32> Address { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String Attention { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<System.DateTime> FinishDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public byte IsDefault { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String MailStop { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.Int32> Relate { get; set; } 

            public System.Guid SiteID { get; set; } 

            public System.String SiteType { get; set; } 

            public System.String SortString { get; set; } 

            public Nullable<System.DateTime> StartDate { get; set; } 

            public Nullable<System.Guid> SyncID { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

