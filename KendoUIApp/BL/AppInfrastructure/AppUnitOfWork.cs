using Riganti.Utils.Infrastructure.EntityFramework;
using System;
using Riganti.Utils.Infrastructure.Core;
using System.Data.Entity;
using DAL;

namespace BL.AppInfrastructure
{
    public class AppUnitOfWork : EntityFrameworkUnitOfWork
    {
        public new AppDbContext Context => (AppDbContext)base.Context;

        public AppUnitOfWork(IUnitOfWorkProvider provider, Func<DbContext> dbContextFactory, DbContextOptions options) : base(provider, dbContextFactory, options)
        {
        }
    }
}
