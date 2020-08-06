using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.RepositoryInterfaces;
using HotelManagementSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Infrastructure.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            roomRepository = _roomRepository;
        }
        public async Task<Room> GetRoomByCustomer(int Id)
        {
            var room = await _roomRepository.GetRoomByCustomer(Id);
            return room;
        }

        public async Task<Room> AddRoom(Room room)
        {
            var addRoom = await _roomRepository.AddAsync(room);
            return addRoom;
        }

        public async Task DeleteRoom(Room room)
        {
            await _roomRepository.DeleteAsync(room);
            
        }
    }
}
