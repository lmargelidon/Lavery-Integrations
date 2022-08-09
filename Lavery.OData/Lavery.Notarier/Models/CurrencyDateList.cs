
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class CurrencyDateList 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  CurrencyDateList()
        {

        }
 
			[Key]
            public System.String Code { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String ChrgCurrencyType { get; set; } 

            public System.String ChrgDateMethod { get; set; } 

            public System.String ChrgRoundingMethod { get; set; } 

            public System.String CostCurrencyType { get; set; } 

            public System.String CostDateMethod { get; set; } 

            public System.String CostRoundingMethod { get; set; } 

            public System.Guid CurrencyDateListID { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public byte Is_Default { get; set; } 

            public byte IsActive { get; set; } 

            public byte IsStock { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String SortString { get; set; } 

            public System.String TimeCurrencyType { get; set; } 

            public System.String TimeDateMethod { get; set; } 

            public System.String TimeRoundingMethod { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}

