
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class LxLabel 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  LxLabel()
        {

        }
 
			[Key]
            public System.Int32 LabelIndex { get; set; } 

            public System.String LabelHash { get; set; } 

            public System.String LabelString { get; set; } 

            public System.Guid LxLabelID { get; set; } 

            public System.DateTime Timestamp { get; set; }
    }
}

