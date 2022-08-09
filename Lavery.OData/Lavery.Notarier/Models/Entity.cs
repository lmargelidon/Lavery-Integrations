
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Entity 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Entity()
        {

        }
 
			[Key]
            public System.Int32 EntIndex { get; set; } 

            public System.String AltNum { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String Comment { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Guid EntityID { get; set; } 

            public Nullable<System.Int32> EntitySanction { get; set; } 

            public System.String EntityType { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public Nullable<byte> Is3EOwned { get; set; } 

            public byte IsChangeAll { get; set; } 

            public byte IsMerged { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.Guid> SyncID { get; set; } 

            public System.String TaxID { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

