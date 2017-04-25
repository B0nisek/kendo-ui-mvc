using Castle.MicroKernel.Registration;
using System;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Riganti.Utils.Infrastructure.Core;
using System.Data.Entity;
using BL.AppInfrastructure;
using Riganti.Utils.Infrastructure.EntityFramework;
using BL.Services;
using DAL;
using BL.Facade;

namespace BL.Bootstrap
{
    public class DataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                   Component.For<Func<DbContext>>()
                       .Instance(() => new AppDbContext())
                       .LifestyleTransient(),

                   Component.For<IUnitOfWorkProvider>()
                       .ImplementedBy<AppUnitOfWorkProvider>()
                       .LifestyleSingleton(),
                   
                   Component.For(typeof(IRepository<,>))
                       .ImplementedBy(typeof(EntityFrameworkRepository<,>))
                       .LifestyleTransient(),

                   Classes.FromAssemblyContaining<AppUnitOfWork>()
                       .BasedOn(typeof(AppQuery<>))
                       .LifestyleTransient(),

                   Classes.FromAssemblyContaining<AppUnitOfWork>()
                       .BasedOn(typeof(IRepository<,>))
                       .LifestyleTransient(),

                   Classes.FromThisAssembly()
                       .BasedOn<ServiceBase>()
                       .WithServiceDefaultInterfaces()
                       .LifestyleTransient(),

                    Component.For<CustomerFacade>(),

                    Classes.FromThisAssembly()
                        .InNamespace("BL.Facade")
                        .LifestyleTransient()
               );

            Mapping.ConfigureMapping();
        }
    }
}
