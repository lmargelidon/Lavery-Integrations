
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class GLProject : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime EstCompDate { get; set; } 

            public System.Guid GLActivity { get; set; } 

            public System.Guid GLNatural { get; set; } 
			[Key]
            public System.Guid GLProjectID { get; set; } 

            public System.Int32 ProjIndex { get; set; } 

            public System.String ProjNum { get; set; }
    }
}

