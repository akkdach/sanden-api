using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class work_order_refurbish
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [MaxLength(1)]
        public string STATION_NO { get; set; }

        [MaxLength(8)]
        public string WORK_CENTER { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? FINISHDATE { get; set; }

        [MaxLength(1)]
        public string STATUS { get; set; }

        [MaxLength(8)]
        public string CREATE_BY { get; set; }

        public DateTime? CREATE_DATE { get; set; }

        [MaxLength(8)]
        public string UPDATE_BY { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

    }
}
