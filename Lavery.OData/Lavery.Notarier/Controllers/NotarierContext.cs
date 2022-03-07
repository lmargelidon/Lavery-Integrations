
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lavery.OData.Notarier.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Lavery.OData.Notarier.Controllers
{
    public class NotarierContext : DbContext
    {

        public NotarierContext() : base("NotarierContext")
        {
        }
		public DbSet<InvMaster> InvMasters { get; set; }
		public DbSet<MattBudget> MattBudgets { get; set; }
		public DbSet<Matter> Matters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Database.SetInitializer<NotarierContext>(null);
			base.OnModelCreating(modelBuilder);						
        }
    }
}

