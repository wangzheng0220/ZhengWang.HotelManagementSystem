using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;

namespace HotelManagementSystem.Core.Entities
{
    public class RoomType
    {
        [Required]
        public int Id { get; set; }
        public string RTDESC { get; set; }
        [Column(TypeName ="decimal(18,4)")]
        public decimal Rent { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
