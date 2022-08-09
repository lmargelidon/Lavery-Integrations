
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class ElecBillingType 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  ElecBillingType()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.String EleBillPassword { get; set; } 

            public System.Guid ElecBillingTypeID { get; set; } 

            public System.String ElecBillLogin { get; set; } 

            public System.String ElectronicAddress { get; set; } 

            public System.String ElectronicInfo1 { get; set; } 

            public System.String ElectronicInfo2 { get; set; } 

            public System.String OutputDestination { get; set; }
    }
}

