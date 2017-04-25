using BL.DTO;
using BL.Service.Customers;
using System.Collections.Generic;

namespace BL.Facade
{
    public class CustomerFacade : ICustomerFacade
    {
        private readonly ICustomerService customerService;

        public CustomerFacade(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public CustomerDTO GetCustomer(int id)
        {
            return customerService.GetCustomer(id);
        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return customerService.GetAll();
        }

        public void UpdateCustomer(CustomerDTO customer)
        {
            customerService.Update(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerService.Delete(id);
        }

        public void CreateCustomer(CustomerDTO customer)
        {
            customerService.Create(customer);
        }
    }
}
