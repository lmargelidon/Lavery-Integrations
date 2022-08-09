
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class MattCloseType 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  MattCloseType()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Guid MattCloseTypeID { get; set; }
    }
}

