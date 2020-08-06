using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.RepositoryInterfaces
{
    public interface IServiceRepository:IAsyncRepository<Service>
    {
        Task<Service> GetServiceByCustomer(int Id);
    }
}
