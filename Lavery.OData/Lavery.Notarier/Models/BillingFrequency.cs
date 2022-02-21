
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class BillingFrequency : Object
    {
 
			[Key]
            public System.Guid BillingFrequencyID { get; set; } 

            public System.String Code { get; set; } 

            public System.String Description { get; set; }
    }
}

