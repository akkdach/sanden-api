using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class Clock_InOut
    {
        [Key]
        public int Id { get; set; } //Primary Key

        public string UserId { get; set; } //User

        public string ClockInTime { get; set; } // Stamp In
        public DateTime ClockInDate { get; set; }

        public string ClockOutTime { get; set; } // Stamp Out
        public DateTime? ClockOutDate { get; set; }

        public DateTime? CreatedDate { get; set; }
        public bool IsClockSuccess { get; set; }
    }
}
