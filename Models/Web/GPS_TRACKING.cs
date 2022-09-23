using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class GPS_TRACKING
    {

        [Key]
        public int TRACKING_ID { get; set; }

        public DateTime CREATE_DATETIME { get; set; }

        public string USERNAME { get; set; }

        public string WK_CTR { get; set; }

        public decimal LAT { get; set; }

        public decimal LONG { get; set; }

        public double ACCURACY { get; set; }

        public double HEADING { get; set; }

        public double SPEED { get; set; }

    }
}
