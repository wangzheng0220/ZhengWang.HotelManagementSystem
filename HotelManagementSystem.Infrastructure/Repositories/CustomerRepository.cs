using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Infrastructure.Repositories
{
    public class CustomerRepository: EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

        //public async Task<IEnumerable<Customer>> GetListOfCustomers()
        //{
        //    var customers = await _dbContext.Customers.ToListAsync();
        //    return customers;
        //}
        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await _dbContext.Customers.FirstOrDefaultAsync(c => c.Email == email);
        }


    }
}
