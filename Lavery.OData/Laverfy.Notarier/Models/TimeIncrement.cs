
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class TimeIncrement : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Decimal Increment { get; set; } 

            public System.Boolean IsAutoRound { get; set; } 

            public System.String RndBasisList { get; set; } 
			[Key]
            public System.Guid TimeIncrementID { get; set; }
    }
}

