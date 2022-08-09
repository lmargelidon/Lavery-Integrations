
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class NonBillMatType 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  NonBillMatType()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public byte IsChargeBill { get; set; } 

            public Nullable<byte> IsChargeNB { get; set; } 

            public byte IsCostBill { get; set; } 

            public Nullable<byte> IsCostNB { get; set; } 

            public Nullable<byte> IsDefaultChargeBill { get; set; } 

            public Nullable<byte> IsDefaultCostBill { get; set; } 

            public Nullable<byte> IsDefaultTimeBill { get; set; } 

            public byte IsTimeBill { get; set; } 

            public Nullable<byte> IsTimeNB { get; set; } 

            public System.Guid NonBillMatTypeID { get; set; }
    }
}

