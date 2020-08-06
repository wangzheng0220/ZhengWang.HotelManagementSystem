using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            var dbCustomer = await _customerRepository.GetCustomerByEmail(customer.Email);

            if (dbCustomer != null)
            {
                // we already have this user(email) in our table
                // return or throw an exception saying Conflict user
                throw new Exception("User already booked one room");
            }
            var addedcustomer = await _customerRepository.AddAsync(customer);
            return addedcustomer;
    
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = await _customerRepository.ListAllAsync();
            return customers;
        }

    }
}
