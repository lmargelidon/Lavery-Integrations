
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Language : Object
    {
 

            public System.String Description { get; set; } 

            public System.Boolean IsTranslated { get; set; } 
			[Key]
            public System.Guid LanguageID { get; set; } 

            public System.Int32 Locale { get; set; }
    }
}

