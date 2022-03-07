
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class NxPrinterTemplate : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.Int32 DCSTemplateId { get; set; } 

            public System.String Description { get; set; } 

            public System.String FormatOverride { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Boolean IsDeleted { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String Name { get; set; } 

            public System.String NativeVersion { get; set; } 
			[Key]
            public System.Guid NxPrinterTemplateID { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String TemplateCategory { get; set; } 

            public System.Int32 TemplateType { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.Boolean UseWordApplication { get; set; }
    }
}

