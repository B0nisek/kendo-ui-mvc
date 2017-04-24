using BL.DTO;
using System.Collections.Generic;

namespace BL.Service.Customers
{
    public interface ICustomerService
    {
        void Create(CustomerDTO customerDto);

        IEnumerable<CustomerDTO> GetAll();

        void Update(CustomerDTO customerDto);

        void Delete(int id);

        CustomerDTO GetCustomer(int id);
    }
}