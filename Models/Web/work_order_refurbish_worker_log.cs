using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class work_order_refurbish_worker_log
    {

        [Key]
        public int ID { get; set; }

        //[MaxLength(12)]
        //public string ORDERID { get; set; }

        //[MaxLength(1)]
        //public string STATION_NO { get; set; }

        public string WORK_ORDER_REFURBISH { get; set; }

        [MaxLength(15)]
        public string ACTIVITY { get; set; }

        public DateTime ACTIVITY_DATE { get; set; }

        public string DESCRIPTION { get; set; }

        [MaxLength(8)]
        public string CREATE_BY { get; set; }
        
        public DateTime? CREATE_DATE { get; set; }
    }
}
