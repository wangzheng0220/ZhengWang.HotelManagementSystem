using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<Service> GetServiceByUser(int id);
    }
}