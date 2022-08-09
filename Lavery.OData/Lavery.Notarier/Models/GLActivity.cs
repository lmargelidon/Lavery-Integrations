
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class GLActivity 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  GLActivity()
        {

        }
 

            public System.String Description { get; set; } 

            public System.Guid GLActivityID { get; set; } 

            public System.String GLValue { get; set; }
    }
}

