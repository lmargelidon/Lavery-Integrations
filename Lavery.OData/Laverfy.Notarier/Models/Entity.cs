
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Entity : Object
    {
 

            public System.String AltNum { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.String Comment { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Int32 EntIndex { get; set; } 
			[Key]
            public System.Guid EntityID { get; set; } 

            public System.Int32 EntitySanction { get; set; } 

            public System.String EntityType { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean Is3EOwned { get; set; } 

            public System.Boolean IsChangeAll { get; set; } 

            public System.Boolean IsMerged { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.Guid SyncID { get; set; } 

            public System.String TaxID { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

