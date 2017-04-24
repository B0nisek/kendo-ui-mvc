using BL.AppInfrastructure;
using BL.DTO;
using System.Linq;
using Riganti.Utils.Infrastructure.Core;
using DAL.Entities;
using AutoMapper.QueryableExtensions;

namespace BL.Queries
{
    public class CustomerListQuery : AppQuery<CustomerDTO>
    {
        public CustomerListQuery(IUnitOfWorkProvider provider) : base(provider)
        {
        }

        protected override IQueryable<CustomerDTO> GetQueryable()
        {
            IQueryable<Customer> query = Context.Customers;

            return query.ProjectTo<CustomerDTO>();
        }
    }
}
