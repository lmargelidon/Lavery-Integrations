
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class GLProject 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  GLProject()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<System.DateTime> EstCompDate { get; set; } 

            public Nullable<System.Guid> GLActivity { get; set; } 

            public Nullable<System.Guid> GLNatural { get; set; } 

            public System.Guid GLProjectID { get; set; } 

            public System.Int32 ProjIndex { get; set; } 

            public System.String ProjNum { get; set; }
    }
}

