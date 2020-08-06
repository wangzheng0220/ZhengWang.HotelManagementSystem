using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementSystem.Core.Entities;
using HotelManagementSystem.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }



        [HttpPost]
        [Route("AddRoom")]
        public async Task<IActionResult> AddRoom([FromBody] Room room)
        {
            var addRooms = await _roomService.AddRoom(room);
            return Ok(addRooms);
        }

        [HttpDelete]
        [Route("DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(Room room)
        {
            await _roomService.DeleteRoom(room);
            return Ok();
        }

        //[HttpGet]
        //[Route("Rooms")]
        //public async Task<IActionResult> ListAllRooms()
        //{
        //    var allRooms = await _roomService.GetAllRooms();
        //    return Ok(allRooms);
        //}
    }
}
