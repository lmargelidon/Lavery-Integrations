
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class WPType 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  WPType()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public Nullable<System.Decimal> Bucket1Percent { get; set; } 

            public Nullable<System.Decimal> Bucket2Percent { get; set; } 

            public Nullable<System.Decimal> Bucket3Percent { get; set; } 

            public Nullable<System.Decimal> Bucket4Percent { get; set; } 

            public Nullable<System.Decimal> Bucket5Percent { get; set; } 

            public Nullable<System.Decimal> Bucket6Percent { get; set; } 

            public Nullable<System.Decimal> Bucket7Percent { get; set; } 

            public Nullable<System.Decimal> Bucket8Percent { get; set; } 

            public System.String Description { get; set; } 

            public System.Guid WPTypeID { get; set; }
    }
}

