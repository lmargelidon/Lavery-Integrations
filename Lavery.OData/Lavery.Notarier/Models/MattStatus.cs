
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class MattStatus 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  MattStatus()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public byte IsBilling { get; set; } 

            public byte IsChargeEntry { get; set; } 

            public byte IsCheckOpenDateOnEntry { get; set; } 

            public byte IsClosed { get; set; } 

            public byte IsCostEntry { get; set; } 

            public byte IsIncludeInMobileApps { get; set; } 

            public byte IsPayment { get; set; } 

            public byte IsTimeEntry { get; set; } 

            public byte IsTrust { get; set; } 

            public System.Guid MattStatusID { get; set; }
    }
}

