
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class MattInterest 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  MattInterest()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String ChrgType { get; set; } 

            public System.String Description { get; set; } 

            public byte IsAutoWriteDown { get; set; } 

            public byte IsInvoiceLevel { get; set; } 

            public System.Guid MattInterestID { get; set; } 

            public System.String MattInterestList { get; set; } 

            public System.Decimal Rate { get; set; }
    }
}

