using Riganti.Utils.Infrastructure.Core;
namespace BL.Services
{
    public abstract class ServiceBase
    {
        public IUnitOfWorkProvider UnitOfWorkProvider { get; set; }
    }
}
