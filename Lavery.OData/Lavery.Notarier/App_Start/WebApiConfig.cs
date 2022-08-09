
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Lavery.OData.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;


namespace Lavery.OData.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ODataConventionModelBuilder();            
			builder.EntitySet<Matter>("Matters");
			builder.EntitySet<InvMaster>("InvMasters");
			builder.EntitySet<MattBudget>("MattBudgets");
			builder.EntitySet<Timekeeper>("TimekeeperEntitySet");
			builder.EntitySet<BankAcct>("BankAcctEntitySet");
			builder.EntitySet<NxPrinterTemplate>("NxPrinterTemplateEntitySet");
			builder.EntitySet<BillingFrequency>("BillingFrequencyEntitySet");
			builder.EntitySet<Office>("OfficeEntitySet");
			builder.EntitySet<Site>("SiteEntitySet");
			builder.EntitySet<TaxCode>("TaxCodeEntitySet");
			builder.EntitySet<Client>("ClientEntitySet");
			builder.EntitySet<ConflictStatus>("ConflictStatusEntitySet");
			builder.EntitySet<NxCurrencyCode>("NxCurrencyCodeEntitySet");
			builder.EntitySet<CurrencyDateList>("CurrencyDateListEntitySet");
			builder.EntitySet<EBHArrangement>("EBHArrangementEntitySet");
			builder.EntitySet<EBHClientList>("EBHClientListEntitySet");
			builder.EntitySet<EBillValList>("EBillValListEntitySet");
			builder.EntitySet<ElecBillingType>("ElecBillingTypeEntitySet");
			builder.EntitySet<ElecCostTypeMap>("ElecCostTypeMapEntitySet");
			builder.EntitySet<ElectronicTaxCodeMap>("ElectronicTaxCodeMapEntitySet");
			builder.EntitySet<ElecTitleMap>("ElecTitleMapEntitySet");
			builder.EntitySet<GLActivity>("GLActivityEntitySet");
			builder.EntitySet<GLProject>("GLProjectEntitySet");
			builder.EntitySet<NxFWKUnit>("NxFWKUnitEntitySet");
			builder.EntitySet<InvoiceOverride>("InvoiceOverrideEntitySet");
			builder.EntitySet<Language>("LanguageEntitySet");
			builder.EntitySet<LxLabel>("LxLabelEntitySet");
			builder.EntitySet<Markup>("MarkupEntitySet");
			builder.EntitySet<MattAttribute>("MattAttributeEntitySet");
			builder.EntitySet<MattCategory>("MattCategoryEntitySet");
			builder.EntitySet<MattCloseType>("MattCloseTypeEntitySet");
			builder.EntitySet<MattInterest>("MattInterestEntitySet");
			builder.EntitySet<MattMinType>("MattMinTypeEntitySet");
			builder.EntitySet<MattStatus>("MattStatusEntitySet");
			builder.EntitySet<MattType>("MattTypeEntitySet");
			builder.EntitySet<NonBillMatType>("NonBillMatTypeEntitySet");
			builder.EntitySet<Entity>("EntityEntitySet");
			builder.EntitySet<TimeIncrement>("TimeIncrementEntitySet");
			builder.EntitySet<TaxArea>("TaxAreaEntitySet");
			builder.EntitySet<VolumeDiscountGroup>("VolumeDiscountGroupEntitySet");
			builder.EntitySet<WithholdingTax>("WithholdingTaxEntitySet");
			builder.EntitySet<WPType>("WPTypeEntitySet");
            
            config.MapODataServiceRoute(
            routeName: "ODataRoute",
            routePrefix: null,
            model: builder.GetEdmModel());
            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
        }
    }
}

