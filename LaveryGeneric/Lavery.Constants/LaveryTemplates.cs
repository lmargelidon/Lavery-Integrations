using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Constants
{
    public class LaveryTemplates
    {
        static public String sClasseTemplate = @"
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace {0}
{{
     [DataContract]
    public class {1} : responseBase
    {{
{2}
    }}
}}
";
        static public String sODataClasseTemplate = @"
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace {0}.Models
{{     
    public class {1} : Object
    {{
{2}
    }}
}}
";
        static public String sAttributesTemplate = @"
            [DataMember]
            public {0} {1} {{ get; set; }}";
        static public String sAttributesNullabeTemplate = @"
            [DataMember]
            public Nullable<{0}> {1} {{ get; set; }}";

        static public String sOdataClasseContextTemplate = @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using {0}.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace {0}.Controllers
{{
    public class {1}Context : DbContext
    {{

        public {1}Context() : base(""{1}Context"")
        {{
        }}
{2}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {{
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<{1}Context>(null);
			base.OnModelCreating(modelBuilder);						
        }}
    }}
}}
";
        static public String sODataControllerTemplate = @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.OData;
using {0}.Models;

namespace {0}.Controllers
{{
    public class {1}Controller : ODataController
    {{
        {1}Context db = new {1}Context();
       
        protected override void Dispose(bool disposing)
        {{
            db.Dispose();
            base.Dispose(disposing);
        }}
        [EnableQuery]
        public IQueryable<{2}> Get()
        {{
            List<{2}> oL{2}= db.{2}s.ToList();
            foreach ({2} oEnv in oL{2})
                Console.WriteLine(oEnv);
            

            return db.{2}s;
        }}
    }}
}}";

        static public String sODataWindowsApiConfigTemplate = @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using {0}.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;


namespace {0}.Service
{{
    public static class WebApiConfig
    {{
        public static void Register(HttpConfiguration config)
        {{
            var builder = new ODataConventionModelBuilder();            
{1}
            config.MapODataServiceRoute(""ODataRoute"", null, builder.GetEdmModel());
        }}
    }}
}}
";
        static public String sODataBuilder = @"builder.EntitySet<{0}>(""{1}"");";

        static public String sDbSetTemplate = @"public DbSet<{0}> {0}s {{ get; set; }}";
                

        static public String sOdataAttributesTemplate = @" 
{2}
            public {0} {1} {{ get; set; }}";
        static public String sOdataAttributesNullabeTemplate = @" 
{2}
            public Nullable<{0}> {1} {{ get; set; }}";

    }
}

