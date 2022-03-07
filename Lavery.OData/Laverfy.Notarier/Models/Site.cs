
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Site : Object
    {
 

            public System.Int32 Address { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String Attention { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime FinishDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean IsDefault { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String MailStop { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.Int32 Relate { get; set; } 
			[Key]
            public System.Guid SiteID { get; set; } 

            public System.Int32 SiteIndex { get; set; } 

            public System.String SiteType { get; set; } 

            public System.String SortString { get; set; } 

            public System.DateTime StartDate { get; set; } 

            public System.Guid SyncID { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

