
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class TaxCode 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  TaxCode()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public Nullable<System.Decimal> BillDisplayTaxRate { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<System.Guid> GLNatural1 { get; set; } 

            public Nullable<System.Guid> GLNatural2 { get; set; } 

            public Nullable<System.Guid> GLNatural3 { get; set; } 

            public byte IsAP { get; set; } 

            public byte IsNoTax { get; set; } 

            public byte IsOverrideDefault { get; set; } 

            public byte IsRateBillDate { get; set; } 

            public System.Guid TaxCodeID { get; set; } 

            public System.String TaxRndBasisList { get; set; } 

            public System.String TaxTypeList { get; set; }
    }
}

