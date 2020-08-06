using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagementSystem.Core.Entities
{
    public class Room
    {
        [Required]
        public int Id { get; set; }
        public int Rtcode { get; set; }

        public int Status { get; set; }

        public int CustomerId { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Service> Services { get; set; }
        public RoomType RoomType { get; set; }
    }
}
