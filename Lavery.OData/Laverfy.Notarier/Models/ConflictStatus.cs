
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class ConflictStatus : Object
    {
 

            public System.String Code { get; set; } 
			[Key]
            public System.Guid ConflictStatusID { get; set; } 

            public System.String Description { get; set; }
    }
}

