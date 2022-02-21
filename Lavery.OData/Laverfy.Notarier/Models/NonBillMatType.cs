
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class NonBillMatType : Object
    {
 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean IsChargeBill { get; set; } 

            public System.Boolean IsChargeNB { get; set; } 

            public System.Boolean IsCostBill { get; set; } 

            public System.Boolean IsCostNB { get; set; } 

            public System.Boolean IsDefaultChargeBill { get; set; } 

            public System.Boolean IsDefaultCostBill { get; set; } 

            public System.Boolean IsDefaultTimeBill { get; set; } 

            public System.Boolean IsTimeBill { get; set; } 

            public System.Boolean IsTimeNB { get; set; } 
			[Key]
            public System.Guid NonBillMatTypeID { get; set; }
    }
}

