using BL.DTO;
using System.Collections.Generic;

namespace BL.Facade
{
    public interface ICustomerFacade
    {
        CustomerDTO GetCustomer(int id);

        IEnumerable<CustomerDTO> GetCustomers();

        void UpdateCustomer(CustomerDTO customer);

        void DeleteCustomer(int id);

        void CreateCustomer(CustomerDTO customer);
    }
}
