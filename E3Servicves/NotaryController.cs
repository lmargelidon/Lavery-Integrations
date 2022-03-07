using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.OData;
using E3Services.Models;

namespace E3Services.Controllers
{
    public class NotaryController : ODataController
    {
        NotaryContext db = new NotaryContext();
        private bool DocumentsExists(int key)
        {
            return db.Documents.Any(p => p.id == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [EnableQuery]
        public IQueryable<Notary> Get()
        {
            return db.Documents;
        }
        [EnableQuery]
        public SingleResult<Notary> Get([FromODataUri] int key)
        {
            IQueryable<Notary> result = db.Documents.Where(p => p.id == key);
            return SingleResult.Create(result);
        }
        public async Task<IHttpActionResult> Post(Notary product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Documents.Add(product);
            await db.SaveChangesAsync();
            return Created(product);
        }
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Notary> product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Documents.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            product.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentsExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(entity);
        }
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Notary update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.id)
            {
                return BadRequest();
            }
            db.Entry(update).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentsExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(update);
        }
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            var product = await db.Documents.FindAsync(key);
            if (product == null)
            {
                return NotFound();
            }
            db.Documents.Remove(product);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}