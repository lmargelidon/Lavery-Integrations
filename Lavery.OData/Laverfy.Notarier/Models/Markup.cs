
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Markup : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.String Code { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Guid LastProcItemID { get; set; } 
			[Key]
            public System.Guid MarkupID { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String RoundingMethod { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

