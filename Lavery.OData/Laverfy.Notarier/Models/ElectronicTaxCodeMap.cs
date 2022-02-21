
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class ElectronicTaxCodeMap : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 
			[Key]
            public System.Guid ElectronicTaxCodeMapID { get; set; } 

            public System.Guid LangDescription { get; set; }
    }
}

