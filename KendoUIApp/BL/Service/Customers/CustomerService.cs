using BL.Repository;
using AutoMapper;
using DAL.Entities;
using BL.Services;
using BL.DTO;
using System;
using System.Collections.Generic;
using BL.Queries;

namespace BL.Service.Customers
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        private readonly CustomerRepository customerRepository;
        private readonly CustomerListQuery customerListQuery;

        public CustomerService(CustomerRepository customerRepository, CustomerListQuery customerListQuery)
        {
            this.customerRepository = customerRepository;
            this.customerListQuery = customerListQuery;
        }

        public void Create(CustomerDTO customerDto)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                var customer = Mapper.Map<Customer>(customerDto);

                customerRepository.Insert(customer);

                uow.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                customerRepository.Delete(id);
                uow.Commit();
            }
        }

        public void Update(CustomerDTO customerDto)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                var customer = customerRepository.GetById(customerDto.Id);
                Mapper.Map(customerDto, customer);

                customerRepository.Update(customer);

                uow.Commit();
            }
        }

        public CustomerDTO GetCustomer(int id)
        {
            using (UnitOfWorkProvider.Create())
            {
                var customer = customerRepository.GetById(id);
                return customer != null ? Mapper.Map<CustomerDTO>(customer) : null;
            }
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            using (UnitOfWorkProvider.Create())
            {
                var customers = customerListQuery.Execute();
                return Mapper.Map<List<CustomerDTO>>(customers);
            }
        }
    }
}
