using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<Room> GetRoomByCustomer(int Id);

        Task<Room> AddRoom(Room room);

        Task DeleteRoom(Room room);
    }
}
