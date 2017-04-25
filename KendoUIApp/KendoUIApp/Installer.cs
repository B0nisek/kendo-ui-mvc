using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace KendoUIApp
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly()
                    .BasedOn<IController>()
                    .If(t => t.Name.EndsWith("Controller"))
                    .If(t => t.Namespace.StartsWith("KendoUIApp.Controllers"))
                    .Configure(c => c.LifestylePerWebRequest())
                    );
        }
    }
}