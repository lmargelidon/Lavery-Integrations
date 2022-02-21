
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class WPType : Object
    {
 

            public System.Decimal Bucket1Percent { get; set; } 

            public System.Decimal Bucket2Percent { get; set; } 

            public System.Decimal Bucket3Percent { get; set; } 

            public System.Decimal Bucket4Percent { get; set; } 

            public System.Decimal Bucket5Percent { get; set; } 

            public System.Decimal Bucket6Percent { get; set; } 

            public System.Decimal Bucket7Percent { get; set; } 

            public System.Decimal Bucket8Percent { get; set; } 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 
			[Key]
            public System.Guid WPTypeID { get; set; }
    }
}

