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
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

            public RoomTypeController(IRoomTypeService roomTypeService)
            {
                _roomTypeService = roomTypeService;
            }

        [HttpPost]
        [Route("AddRoomType")]
        public async Task<IActionResult> AddRoomType([FromBody] RoomType roomType)
        {
            var addRooms = await _roomTypeService.AddRoomType(roomType);
            return Ok(addRooms);
        }

        [HttpDelete]
        [Route("DeleteRoom")]
        public async Task<IActionResult> DeleteRoomType(RoomType roomType)
        {
            await _roomTypeService.DeleteRoomType(roomType);
            return Ok();
        }
    }
    }
