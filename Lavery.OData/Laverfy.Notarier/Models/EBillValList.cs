
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class EBillValList : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Currency { get; set; } 

            public System.String CurrencyType { get; set; } 

            public System.String Description { get; set; } 
			[Key]
            public System.Guid EBillValListID { get; set; } 

            public System.String PTAGroup { get; set; }
    }
}

