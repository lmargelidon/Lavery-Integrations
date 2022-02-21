
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class GLActivity : Object
    {
 

            public System.String Description { get; set; } 
			[Key]
            public System.Guid GLActivityID { get; set; } 

            public System.String GLValue { get; set; }
    }
}

