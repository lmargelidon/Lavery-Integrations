
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class TaxArea : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Country { get; set; } 

            public System.String Description { get; set; } 
			[Key]
            public System.Guid TaxAreaID { get; set; }
    }
}

