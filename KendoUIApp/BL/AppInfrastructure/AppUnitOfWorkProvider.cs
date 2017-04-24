using Riganti.Utils.Infrastructure.EntityFramework;
using System;
using Riganti.Utils.Infrastructure.Core;
using System.Data.Entity;

namespace BL.AppInfrastructure
{
    public class AppUnitOfWorkProvider : EntityFrameworkUnitOfWorkProvider
    {
        public AppUnitOfWorkProvider(IUnitOfWorkRegistry registry, Func<DbContext> dbContextFactory)
            : base(registry, dbContextFactory)
        {
        }

        protected override EntityFrameworkUnitOfWork CreateUnitOfWork(Func<DbContext> dbContextFactory, DbContextOptions options)
        {
            return new AppUnitOfWork(this, dbContextFactory, options);
        }
    }
}
