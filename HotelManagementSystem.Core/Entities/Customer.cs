using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagementSystem.Core.Entities
{
    public class Customer
    {
        public Customer()
        {
            Checkin = DateTime.Now;
        }
        [Required]
        public int Id { get; set; }
        public int Roomno { get; set; }

        [StringLength(20)]
        public string Cname { get; set; }
        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public int TotalPersons { get; set; }
        public int Bookingdays { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Advance { get; set; }

        public Room Room { get; set; }
    }
}
