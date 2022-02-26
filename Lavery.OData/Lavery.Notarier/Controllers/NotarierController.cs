
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.OData;
using Lavery.OData.Notarier.Models;


namespace Lavery.OData.Notarier.Controllers
{
    public class NotarierController : ODataController
    {
        NotarierContext db;

        public NotarierController()
        {
            db = new NotarierContext();
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
            List<Matter> oLMatter= db.Matters.ToList();
            foreach (Matter oEnv in oLMatter)
                Console.WriteLine(oEnv);
            

            return db.Matters;
        }
    }
}
