
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class MattMinType 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  MattMinType()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public Nullable<System.DateTime> CurrDate { get; set; } 

            public System.String Currency { get; set; } 

            public System.String Description { get; set; } 

            public byte IsMeetAllCriteria { get; set; } 

            public System.Guid MattMinTypeID { get; set; } 

            public Nullable<System.Decimal> MinCharges { get; set; } 

            public Nullable<System.Decimal> MinCosts { get; set; } 

            public Nullable<System.Decimal> MinFees { get; set; } 

            public Nullable<System.Decimal> MinTotal { get; set; }
    }
}

