
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class EBHArrangement 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  EBHArrangement()
        {

        }
 
			[Key]
            public System.String EBHArrangementCode { get; set; } 

            public System.String EBHArrangementDesc { get; set; } 

            public System.Guid EBHArrangementID { get; set; } 

            public byte IsStock { get; set; }
    }
}

