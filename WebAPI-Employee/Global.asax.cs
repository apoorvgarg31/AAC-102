using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAPI_Employee
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
        public SqlConnection con;
        //To Handle connection related activities
        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["data source=localhost\\sqlexpress;initial catalog=CommodityInfo;integrated security=True;MultipleActiveResultSets=True"].ToString();
            con = new SqlConnection(constr);
        }
    }
}
