using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Infrastructure.Repositories
{
    public class ServiceRepository : EfRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelManagementSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<Service> GetServiceByCustomer(int Id)
        {
            //return await _dbContext.Services.InclWhere(r => r.CustomerId == Id).FirstOrDefaultAsync();
            var service = await _dbContext.Services.Include(s => s.Room).ThenInclude(r => r.Customers)
                .Where(c => c.Id == Id).FirstOrDefaultAsync();
            return service;
        }
    }
}