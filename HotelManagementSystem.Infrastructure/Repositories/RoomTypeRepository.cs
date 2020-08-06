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
    public class RoomTypeRepository : EfRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HotelManagementSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<RoomType> GetRoomtypeByRoomId(int Id)
        {
            //return await _dbContext.Rooms.Select(r => r.Rtcode).Where(e => e == e.RoomTypeId);
            //var roomType = await (from rt in _dbContext.RoomTypes
            //                      join r in _dbContext.Rooms on rt.Id equals r.Rtcode
            //                      where r.Id == Id
            //                      select rt.RTDESC).FirstOrDefault();
            return await _dbContext.RoomTypes.Include(t => t.Rooms).Where(r => r.Id == Id).FirstOrDefaultAsync();

        }

        // select RTDESC from RoomType join room on roomtype.id = room.rtcode where id=Id 
    }
}
