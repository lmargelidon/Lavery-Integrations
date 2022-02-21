
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class WithholdingTax : Object
    {
 

            public System.Int32 APGLAcctMask { get; set; } 

            public System.String ChrgType { get; set; } 

            public System.String Code { get; set; } 

            public System.String Currency { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean IsApplyToWholeYear { get; set; } 

            public System.Boolean IsCharge { get; set; } 

            public System.Boolean IsCost { get; set; } 

            public System.Boolean IsFee { get; set; } 

            public System.Boolean IsVoucher { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public System.String RptCurrencyType { get; set; } 

            public System.String TranType { get; set; } 
			[Key]
            public System.Guid WithholdingTaxID { get; set; }
    }
}

