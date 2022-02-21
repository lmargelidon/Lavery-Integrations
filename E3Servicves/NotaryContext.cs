using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace E3Services.Models
{
    public class NotaryContext : DbContext
    {
        public DbSet<Notary> Documents { get; set; }
        public NotaryContext() : base("name=NotaryContext")
        {
        }

    }
}