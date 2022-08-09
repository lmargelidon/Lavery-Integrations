
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class NxPrinterTemplate 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  NxPrinterTemplate()
        {

        }
 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.Int32 DCSTemplateId { get; set; } 

            public System.String Description { get; set; } 

            public System.String FormatOverride { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public Nullable<byte> IsActive { get; set; } 

            public Nullable<byte> IsDeleted { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String Name { get; set; } 

            public System.String NativeVersion { get; set; } 

            public System.Guid NxPrinterTemplateID { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String PreviousNativeVersion { get; set; } 

            public System.String TemplateCategory { get; set; } 

            public Nullable<System.Int32> TemplateType { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public Nullable<byte> UseWordApplication { get; set; }
    }
}

