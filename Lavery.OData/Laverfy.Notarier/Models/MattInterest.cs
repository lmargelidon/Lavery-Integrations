
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class MattInterest : Object
    {
 

            public System.String ChrgType { get; set; } 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean IsAutoWriteDown { get; set; } 

            public System.Boolean IsInvoiceLevel { get; set; } 
			[Key]
            public System.Guid MattInterestID { get; set; } 

            public System.String MattInterestList { get; set; } 

            public System.Decimal Rate { get; set; }
    }
}

