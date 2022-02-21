
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class VolumeDiscountGroup : Object
    {
 

            public System.String AdjType { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String ChrgType { get; set; } 

            public System.String Code { get; set; } 

            public System.Int32 CreditAcct { get; set; } 

            public System.String Currency { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.Int32 DebitAcct { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String IncreaseChrgType { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String Office { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String RcptType { get; set; } 

            public System.DateTime Startdate { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.String VolumeDiscountCalcList { get; set; } 
			[Key]
            public System.Guid VolumeDiscountGroupID { get; set; }
    }
}

