
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class TaxCode : Object
    {
 

            public System.Decimal BillDisplayTaxRate { get; set; } 

            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Guid GLNatural1 { get; set; } 

            public System.Guid GLNatural2 { get; set; } 

            public System.Guid GLNatural3 { get; set; } 

            public System.Boolean IsAP { get; set; } 

            public System.Boolean IsNoTax { get; set; } 

            public System.Boolean IsOverrideDefault { get; set; } 

            public System.Boolean IsRateBillDate { get; set; } 
			[Key]
            public System.Guid TaxCodeID { get; set; } 

            public System.String TaxRndBasisList { get; set; } 

            public System.String TaxTypeList { get; set; }
    }
}

