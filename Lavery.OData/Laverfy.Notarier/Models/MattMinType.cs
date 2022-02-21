
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class MattMinType : Object
    {
 

            public System.String Code { get; set; } 

            public System.DateTime CurrDate { get; set; } 

            public System.String Currency { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean IsMeetAllCriteria { get; set; } 
			[Key]
            public System.Guid MattMinTypeID { get; set; } 

            public System.Decimal MinCharges { get; set; } 

            public System.Decimal MinCosts { get; set; } 

            public System.Decimal MinFees { get; set; } 

            public System.Decimal MinTotal { get; set; }
    }
}

