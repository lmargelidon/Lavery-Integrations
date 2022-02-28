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
using System.ComponentModel.DataAnnotations.Schema;

namespace {0}.Models
{{     
    public class {1} 
    {{
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Microsoft.Usage"", ""CA2214:DoNotCallOverridableMethodsInConstructors"")]
        public  {1}()
        {{
{3}
        }}
{2}
    }}
}}
";
        static public String sOSataAddIntializeTemplate = @"this.{0} = new HashSet<{1}>();";
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
            //Database.SetInitializer<{1}Context>(null);
			base.OnModelCreating(modelBuilder);						
        }}
    }}
}}
";
        static public String sODataControllerTemplate = @"
using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using System.Linq;
using System.Web.Http;
using Lavery.ODataMatter.Models;

namespace {0}.Controllers
{{
    public class {1}Controller : ODataController
    {{
        {1}Context db;

        public {1}Controller()
        {{
            db = new {1}Context();
            db.Configuration.ProxyCreationEnabled = false;
        }}
       
        protected override void Dispose(bool disposing)
        {{
            db.Dispose();
            base.Dispose(disposing);
        }}
        [EnableQuery]
        public IQueryable<{2}> Get()
        {{  

            return db.{2}s;
        }}
        [EnableQuery]
        public System.Web.Http.SingleResult<Matter> Get([FromODataUri] int key)
        {{
            IQueryable<{2}> result = db.{2}s.Where(p => p.{3} == key);
            return SingleResult.Create(result);
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
            config.MapODataServiceRoute(
            routeName: ""ODataRoute"",
            routePrefix: null,
            model: builder.GetEdmModel());
            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
        }}
    }}
}}
";
        static public String sODataBuilderEntityset = @"builder.EntitySet<{0}>(""{1}"");";


        static public String sODataInverseRelationAttribut =
            @"InverseProperty(  ""Link{0}And{1}""), 
            System.Diagnostics.CodeAnalysis.SuppressMessage(""Microsoft.Usage"", ""CA2227:CollectionPropertiesShouldBeReadOnly"")";


        static public String sODataDirectRelationAttributForInverRelation = @"ForeignKey(""Link{0}And{1}"")";
        static public String sODataDirectRelationFieldForInverRelation = @"Link{0}And{1}";

        static public String sODataDirectRelationAttribut = @"ForeignKey(""{0}EntitySet"")";
        static public String sODataDirectRelationField = @"{0}EntitySet";

        static public String sDbSetTemplate = @"public DbSet<{0}> {1} {{ get; set; }}";
                

        static public String sOdataAttributesTemplate = @" 
{2}
            public {0} {1} {{ get; set; }}";
        static public String sOdataAttributesNullabeTemplate = @" 
{2}
            public Nullable<{0}> {1} {{ get; set; }}";

    }
}

