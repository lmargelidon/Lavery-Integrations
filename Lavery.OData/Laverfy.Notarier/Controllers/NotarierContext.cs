
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

        public NotarierContext() : base("Notarier")
        {
        }
		public DbSet<BankAcct> BankAccts { get; set; }
		public DbSet<BillingFrequency> BillingFrequencys { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<ConflictStatus> ConflictStatuss { get; set; }
		public DbSet<CurrencyDateList> CurrencyDateLists { get; set; }
		public DbSet<EBillValList> EBillValLists { get; set; }
		public DbSet<ElecBillingType> ElecBillingTypes { get; set; }
		public DbSet<ElecCostTypeMap> ElecCostTypeMaps { get; set; }
		public DbSet<ElecTitleMap> ElecTitleMaps { get; set; }
		public DbSet<ElectronicTaxCodeMap> ElectronicTaxCodeMaps { get; set; }
		public DbSet<Entity> Entitys { get; set; }
		public DbSet<GLActivity> GLActivitys { get; set; }
		public DbSet<GLProject> GLProjects { get; set; }
		public DbSet<InvMaster> InvMasters { get; set; }
		public DbSet<InvoiceOverride> InvoiceOverrides { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<LxLabel> LxLabels { get; set; }
		public DbSet<Markup> Markups { get; set; }
		public DbSet<MattAttribute> MattAttributes { get; set; }
		public DbSet<MattBudget> MattBudgets { get; set; }
		public DbSet<MattCategory> MattCategorys { get; set; }
		public DbSet<MattCloseType> MattCloseTypes { get; set; }
		public DbSet<Matter> Matters { get; set; }
		public DbSet<MattInterest> MattInterests { get; set; }
		public DbSet<MattMinType> MattMinTypes { get; set; }
		public DbSet<MattStatus> MattStatuss { get; set; }
		public DbSet<MattType> MattTypes { get; set; }
		public DbSet<NonBillMatType> NonBillMatTypes { get; set; }
		public DbSet<NxCurrencyCode> NxCurrencyCodes { get; set; }
		public DbSet<NxFWKUnit> NxFWKUnits { get; set; }
		public DbSet<NxPrinterTemplate> NxPrinterTemplates { get; set; }
		public DbSet<Office> Offices { get; set; }
		public DbSet<Site> Sites { get; set; }
		public DbSet<TaxArea> TaxAreas { get; set; }
		public DbSet<TaxCode> TaxCodes { get; set; }
		public DbSet<TimeIncrement> TimeIncrements { get; set; }
		public DbSet<Timekeeper> Timekeepers { get; set; }
		public DbSet<VolumeDiscountGroup> VolumeDiscountGroups { get; set; }
		public DbSet<WithholdingTax> WithholdingTaxs { get; set; }
		public DbSet<WPType> WPTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

