
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class BillingFrequency 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  BillingFrequency()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.Guid BillingFrequencyID { get; set; } 

            public System.String Description { get; set; }
    }
}

