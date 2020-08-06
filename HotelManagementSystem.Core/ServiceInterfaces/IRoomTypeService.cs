using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.ServiceInterfaces
{
    public interface IRoomTypeService
    {
        Task<RoomType> GetRoomTypeByRoomId(int Id);

        Task<RoomType> AddRoomType(RoomType roomType);

        Task DeleteRoomType(RoomType roomType);
    }
}
