using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.RepositoryInterfaces
{
    public interface IRoomRepository:IAsyncRepository<Room>
    {
        Task<Room> GetRoomByCustomer(int Id);
    }
}
