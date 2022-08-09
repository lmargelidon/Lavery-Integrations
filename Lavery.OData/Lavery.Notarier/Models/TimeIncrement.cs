
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class TimeIncrement 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  TimeIncrement()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String Description { get; set; } 

            public System.Decimal Increment { get; set; } 

            public Nullable<byte> IsAutoRound { get; set; } 

            public System.String RndBasisList { get; set; } 

            public System.Guid TimeIncrementID { get; set; }
    }
}

