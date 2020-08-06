using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Core.Entities
{
    public class Service
    {
        [Required]
        public int Id { get; set; }
        public int Roomno { get; set; }

        [StringLength(50)]
        public string Sdesc { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
        public DateTime Servicedate { get; set; }

        public Room Room { get; set; }
    }
}
