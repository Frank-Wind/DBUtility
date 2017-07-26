﻿using DBUtility.WebUI.ViewModels;
using MvcContrib.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DBUtility.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Partial view model binders
            //ModelBinders.Binders.Add(typeof(_PartialVM), new PartialViewModelBinder());
            //ModelBinders.Binders.Add(typeof(_PartialVM), new DerivedTypeModelBinder());

            ModelBinders.Binders.DefaultBinder = new CustomModelBinder();
        }
    }
}
