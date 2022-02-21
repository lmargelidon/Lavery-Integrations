
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Lavery.OData.Notarier.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;


namespace Lavery.OData.Notarier.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ODataConventionModelBuilder();            
		builder.EntitySet<Matter>("Notarier");		
		builder.EntitySet<BankAcct>("BankAcct");
		builder.EntitySet<BillingFrequency>("BillingFrequency");
		builder.EntitySet<Client>("Client");
		builder.EntitySet<ConflictStatus>("ConflictStatus");
		builder.EntitySet<CurrencyDateList>("CurrencyDateList");
		builder.EntitySet<EBillValList>("EBillValList");
		builder.EntitySet<ElecBillingType>("ElecBillingType");
		builder.EntitySet<ElecCostTypeMap>("ElecCostTypeMap");
		builder.EntitySet<ElecTitleMap>("ElecTitleMap");
		builder.EntitySet<ElectronicTaxCodeMap>("ElectronicTaxCodeMap");
		builder.EntitySet<Entity>("Entity");
		builder.EntitySet<GLActivity>("GLActivity");
		builder.EntitySet<GLProject>("GLProject");
		builder.EntitySet<InvMaster>("InvMaster");
		builder.EntitySet<InvoiceOverride>("InvoiceOverride");
		builder.EntitySet<Language>("Language");
		builder.EntitySet<LxLabel>("LxLabel");
		builder.EntitySet<Markup>("Markup");
		builder.EntitySet<MattAttribute>("MattAttribute");
		builder.EntitySet<MattBudget>("MattBudget");
		builder.EntitySet<MattCategory>("MattCategory");
		builder.EntitySet<MattCloseType>("MattCloseType");
		builder.EntitySet<MattInterest>("MattInterest");
		builder.EntitySet<MattMinType>("MattMinType");
		builder.EntitySet<MattStatus>("MattStatus");
		builder.EntitySet<MattType>("MattType");
		builder.EntitySet<NonBillMatType>("NonBillMatType");
		builder.EntitySet<NxCurrencyCode>("NxCurrencyCode");
		builder.EntitySet<NxFWKUnit>("NxFWKUnit");
		builder.EntitySet<NxPrinterTemplate>("NxPrinterTemplate");
		builder.EntitySet<Office>("Office");
		builder.EntitySet<Site>("Site");
		builder.EntitySet<TaxArea>("TaxArea");
		builder.EntitySet<TaxCode>("TaxCode");
		builder.EntitySet<TimeIncrement>("TimeIncrement");
		builder.EntitySet<Timekeeper>("Timekeeper");
		builder.EntitySet<VolumeDiscountGroup>("VolumeDiscountGroup");
		builder.EntitySet<WithholdingTax>("WithholdingTax");
		builder.EntitySet<WPType>("WPType");

            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
        }
    }
}

