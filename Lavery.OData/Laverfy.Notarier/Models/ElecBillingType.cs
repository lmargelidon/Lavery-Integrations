
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class ElecBillingType : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.String EleBillPassword { get; set; } 
			[Key]
            public System.Guid ElecBillingTypeID { get; set; } 

            public System.String ElecBillLogin { get; set; } 

            public System.String ElectronicAddress { get; set; } 

            public System.String ElectronicInfo1 { get; set; } 

            public System.String ElectronicInfo2 { get; set; } 

            public System.String OutputDestination { get; set; }
    }
}

