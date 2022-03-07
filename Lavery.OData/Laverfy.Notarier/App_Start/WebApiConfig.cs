
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
builder.EntitySet<Student>("Notarier");		builder.EntitySet<Student>("BankAcct");
		builder.EntitySet<Student>("BillingFrequency");
		builder.EntitySet<Student>("Client");
		builder.EntitySet<Student>("ConflictStatus");
		builder.EntitySet<Student>("CurrencyDateList");
		builder.EntitySet<Student>("EBillValList");
		builder.EntitySet<Student>("ElecBillingType");
		builder.EntitySet<Student>("ElecCostTypeMap");
		builder.EntitySet<Student>("ElecTitleMap");
		builder.EntitySet<Student>("ElectronicTaxCodeMap");
		builder.EntitySet<Student>("Entity");
		builder.EntitySet<Student>("GLActivity");
		builder.EntitySet<Student>("GLProject");
		builder.EntitySet<Student>("InvMaster");
		builder.EntitySet<Student>("InvoiceOverride");
		builder.EntitySet<Student>("Language");
		builder.EntitySet<Student>("LxLabel");
		builder.EntitySet<Student>("Markup");
		builder.EntitySet<Student>("MattAttribute");
		builder.EntitySet<Student>("MattBudget");
		builder.EntitySet<Student>("MattCategory");
		builder.EntitySet<Student>("MattCloseType");
		builder.EntitySet<Student>("MattInterest");
		builder.EntitySet<Student>("MattMinType");
		builder.EntitySet<Student>("MattStatus");
		builder.EntitySet<Student>("MattType");
		builder.EntitySet<Student>("NonBillMatType");
		builder.EntitySet<Student>("NxCurrencyCode");
		builder.EntitySet<Student>("NxFWKUnit");
		builder.EntitySet<Student>("NxPrinterTemplate");
		builder.EntitySet<Student>("Office");
		builder.EntitySet<Student>("Site");
		builder.EntitySet<Student>("TaxArea");
		builder.EntitySet<Student>("TaxCode");
		builder.EntitySet<Student>("TimeIncrement");
		builder.EntitySet<Student>("Timekeeper");
		builder.EntitySet<Student>("VolumeDiscountGroup");
		builder.EntitySet<Student>("WithholdingTax");
		builder.EntitySet<Student>("WPType");

            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
        }
    }
}

