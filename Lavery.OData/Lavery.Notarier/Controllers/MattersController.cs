
using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using System.Linq;
using System.Web.Http;
using Lavery.OData.Models;

namespace Lavery.OData.Controllers
{
    public class MattersController : ODataController
    {
        MattersContext db;

        public MattersController()
        {
            db = new MattersContext();
            db.Configuration.ProxyCreationEnabled = false;
        }
       
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [EnableQuery]
        public IQueryable<Matter> Get()
        {  

            return db.Matters;
        }
        [EnableQuery]
        public System.Web.Http.SingleResult<Matter> Get([FromODataUri] Int32 key)
        {
            IQueryable<Matter> result = db.Matters.Where(p => p.MattIndex == key);
            return SingleResult.Create(result);
        }
    }
}
