using BL.Bootstrap;
using Castle.Windsor;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KendoUIApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BootstrapContainer();
        }

        private void BootstrapContainer()
        {
            container = new WindsorContainer();

            container.Install(new DataInstaller());
            container.Install(new Installer());

            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
