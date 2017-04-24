using DAL.Entities;
using Riganti.Utils.Infrastructure.EntityFramework;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Repository
{
    public class AddressRepository : EntityFrameworkRepository<Address, int>
    {
        public AddressRepository(IUnitOfWorkProvider provider, IDateTimeProvider dateTimeProvider) : base(provider, dateTimeProvider)
        {
        }
    }
}
