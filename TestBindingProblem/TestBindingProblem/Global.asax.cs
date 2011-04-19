using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TestBindingProblem.AllAroundCode;

namespace TestBindingProblem
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );


            // Or use add a ModelBinder and let ASP.NET MVC engine automagically handle the conversion of money in string format to decimal value.
            // This is in AllAroundCode\Common.cs
            // Sourced from: http://haacked.com/archive/2011/03/19/fixing-binding-to-decimals.aspx
            // Uncomment this, so ASP.NET MVC will be able to convert 1,234
            // ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}