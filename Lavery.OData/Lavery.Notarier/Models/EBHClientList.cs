
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class EBHClientList 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  EBHClientList()
        {

        }
 
			[Key]
            public System.Int32 EBHClientNum { get; set; } 

            public System.Guid EBHClientListID { get; set; } 

            public System.String EBHClientName { get; set; } 

            public Nullable<System.Int32> EBHVendorList { get; set; }
    }
}

