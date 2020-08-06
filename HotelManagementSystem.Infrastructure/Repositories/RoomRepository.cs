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
    public class RoomRepository : EfRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelManagementSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<Room> GetRoomByCustomer(int Id)
        {
            //var room = _dbContext.Rooms.Include(r => r.Customers).FirstOrDefaultAsync(r=>r.email = email);

            //return await _dbContext.Rooms.FirstOrDefaultAsync(c => c.CustomerId == Id);
            return await _dbContext.Rooms.Include(r => r.Customers).Where(r => r.CustomerId == Id).FirstOrDefaultAsync();
            // return await _dbContext.RoomTypes.Include(t => t.Rooms).Where(r => r.Id == Id).FirstOrDefaultAsync();

        }
    }
}
