
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class WithholdingTax 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  WithholdingTax()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public Nullable<System.Int32> APGLAcctMask { get; set; } 

            public System.String ChrgType { get; set; } 

            public System.String Currency { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<byte> IsApplyToWholeYear { get; set; } 

            public byte IsCharge { get; set; } 

            public byte IsCost { get; set; } 

            public byte IsFee { get; set; } 

            public byte IsVoucher { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public System.String RptCurrencyType { get; set; } 

            public System.String TranType { get; set; } 

            public System.Guid WithholdingTaxID { get; set; }
    }
}

