using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Infrastructure.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceService(IServiceRepository serviceRepository)
        {
            serviceRepository = _serviceRepository;
        }

        public async Task<Service> GetServiceByUser(int id)
        {
            return await _serviceRepository.GetServiceByCustomer(id);
        }
    }
}