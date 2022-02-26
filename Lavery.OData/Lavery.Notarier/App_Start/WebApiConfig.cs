
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
			builder.EntitySet<InvMaster>("InvMaster");
			builder.EntitySet<MattBudget>("MattBudget");
            
            config.MapODataServiceRoute(
            routeName: "ODataRoute",
            routePrefix: null,
            model: builder.GetEdmModel());
            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
        }
    }
}

