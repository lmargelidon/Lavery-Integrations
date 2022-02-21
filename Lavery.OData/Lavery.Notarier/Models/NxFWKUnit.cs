
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class NxFWKUnit : Object
    {
 

            public System.String ArchetypeCode { get; set; } 

            public System.String Code { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.Boolean IsActive { get; set; } 

            public System.Guid LastProcItemID { get; set; } 
			[Key]
            public System.Guid NxFWKUnitID { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String SortString { get; set; } 

            public System.DateTime StartDate { get; set; } 

            public System.DateTime TimeStamp { get; set; }
    }
}

