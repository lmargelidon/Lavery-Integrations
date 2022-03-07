
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class MattStatus : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean IsBilling { get; set; } 

            public System.Boolean IsChargeEntry { get; set; } 

            public System.Boolean IsCheckOpenDateOnEntry { get; set; } 

            public System.Boolean IsClosed { get; set; } 

            public System.Boolean IsCostEntry { get; set; } 

            public System.Boolean IsIncludeInMobileApps { get; set; } 

            public System.Boolean IsPayment { get; set; } 

            public System.Boolean IsTimeEntry { get; set; } 

            public System.Boolean IsTrust { get; set; } 
			[Key]
            public System.Guid MattStatusID { get; set; }
    }
}

