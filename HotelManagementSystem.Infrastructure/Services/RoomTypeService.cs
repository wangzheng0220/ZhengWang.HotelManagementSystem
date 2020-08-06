using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Infrastructure.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            roomTypeRepository = _roomTypeRepository;
        }
       

        public async Task<RoomType> GetRoomTypeByRoomId(int Id)
        {
            var roomtype = await _roomTypeRepository.GetRoomtypeByRoomId(Id);
            return roomtype;
        }

        public async Task<RoomType> AddRoomType(RoomType roomType)
        {
            return await _roomTypeRepository.AddAsync(roomType);
        }

        public async Task DeleteRoomType(RoomType roomType)
        {
            await _roomTypeRepository.DeleteAsync(roomType);

        }
    }
}
