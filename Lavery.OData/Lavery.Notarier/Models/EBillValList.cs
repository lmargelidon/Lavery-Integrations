
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class EBillValList 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  EBillValList()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Currency { get; set; } 

            public System.String CurrencyType { get; set; } 

            public System.String Description { get; set; } 

            public System.Guid EBillValListID { get; set; } 

            public System.String PTAGroup { get; set; }
    }
}

