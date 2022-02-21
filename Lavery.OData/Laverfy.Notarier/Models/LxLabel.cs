
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class LxLabel : Object
    {
 

            public System.String LabelHash { get; set; } 

            public System.Int32 LabelIndex { get; set; } 

            public System.String LabelString { get; set; } 
			[Key]
            public System.Guid LxLabelID { get; set; } 

            public System.DateTime Timestamp { get; set; }
    }
}

