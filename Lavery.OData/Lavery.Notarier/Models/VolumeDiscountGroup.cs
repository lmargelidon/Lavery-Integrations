
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class VolumeDiscountGroup 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  VolumeDiscountGroup()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String AdjType { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String ChrgType { get; set; } 

            public Nullable<System.Int32> CreditAcct { get; set; } 

            public System.String Currency { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public Nullable<System.Int32> DebitAcct { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public System.String IncreaseChrgType { get; set; } 

            public byte IsActive { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String Office { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String RcptType { get; set; } 

            public System.DateTime Startdate { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public System.String VolumeDiscountCalcList { get; set; } 

            public System.Guid VolumeDiscountGroupID { get; set; }
    }
}

