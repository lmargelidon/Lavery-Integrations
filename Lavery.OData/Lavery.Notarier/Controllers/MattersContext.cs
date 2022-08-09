
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lavery.OData.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Lavery.OData.Controllers
{
    public class MattersContext : DbContext
    {

        public MattersContext() : base("MattersContext")
        {
        }
		public DbSet<Matter> Matters { get; set; }
		public DbSet<InvMaster> InvMasters { get; set; }
		public DbSet<MattBudget> MattBudgets { get; set; }
		public DbSet<Timekeeper> TimekeeperEntitySet { get; set; }
		public DbSet<BankAcct> BankAcctEntitySet { get; set; }
		public DbSet<NxPrinterTemplate> NxPrinterTemplateEntitySet { get; set; }
		public DbSet<BillingFrequency> BillingFrequencyEntitySet { get; set; }
		public DbSet<Office> OfficeEntitySet { get; set; }
		public DbSet<Site> SiteEntitySet { get; set; }
		public DbSet<TaxCode> TaxCodeEntitySet { get; set; }
		public DbSet<Client> ClientEntitySet { get; set; }
		public DbSet<ConflictStatus> ConflictStatusEntitySet { get; set; }
		public DbSet<NxCurrencyCode> NxCurrencyCodeEntitySet { get; set; }
		public DbSet<CurrencyDateList> CurrencyDateListEntitySet { get; set; }
		public DbSet<EBHArrangement> EBHArrangementEntitySet { get; set; }
		public DbSet<EBHClientList> EBHClientListEntitySet { get; set; }
		public DbSet<EBillValList> EBillValListEntitySet { get; set; }
		public DbSet<ElecBillingType> ElecBillingTypeEntitySet { get; set; }
		public DbSet<ElecCostTypeMap> ElecCostTypeMapEntitySet { get; set; }
		public DbSet<ElectronicTaxCodeMap> ElectronicTaxCodeMapEntitySet { get; set; }
		public DbSet<ElecTitleMap> ElecTitleMapEntitySet { get; set; }
		public DbSet<GLActivity> GLActivityEntitySet { get; set; }
		public DbSet<GLProject> GLProjectEntitySet { get; set; }
		public DbSet<NxFWKUnit> NxFWKUnitEntitySet { get; set; }
		public DbSet<InvoiceOverride> InvoiceOverrideEntitySet { get; set; }
		public DbSet<Language> LanguageEntitySet { get; set; }
		public DbSet<LxLabel> LxLabelEntitySet { get; set; }
		public DbSet<Markup> MarkupEntitySet { get; set; }
		public DbSet<MattAttribute> MattAttributeEntitySet { get; set; }
		public DbSet<MattCategory> MattCategoryEntitySet { get; set; }
		public DbSet<MattCloseType> MattCloseTypeEntitySet { get; set; }
		public DbSet<MattInterest> MattInterestEntitySet { get; set; }
		public DbSet<MattMinType> MattMinTypeEntitySet { get; set; }
		public DbSet<MattStatus> MattStatusEntitySet { get; set; }
		public DbSet<MattType> MattTypeEntitySet { get; set; }
		public DbSet<NonBillMatType> NonBillMatTypeEntitySet { get; set; }
		public DbSet<Entity> EntityEntitySet { get; set; }
		public DbSet<TimeIncrement> TimeIncrementEntitySet { get; set; }
		public DbSet<TaxArea> TaxAreaEntitySet { get; set; }
		public DbSet<VolumeDiscountGroup> VolumeDiscountGroupEntitySet { get; set; }
		public DbSet<WithholdingTax> WithholdingTaxEntitySet { get; set; }
		public DbSet<WPType> WPTypeEntitySet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Database.SetInitializer<MattersContext>(null);
			base.OnModelCreating(modelBuilder);						
        }
    }
}

