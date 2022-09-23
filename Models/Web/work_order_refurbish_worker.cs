using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class work_order_refurbish_worker
    {
        [Key]
        public int ID { get; set; }

        
        public int? WORK_ORDER_REFURBISH { get; set; }
        
        [MaxLength(8)]
        public string EMPLOYEE_ID { get; set; }

        [MaxLength(8)]
        public string WORKER_TIME { get; set; }
    
        [MaxLength(8)]
        public string CREATE_BY { get; set; }
        
        public DateTime? CREATE_DATE { get; set; }

        [MaxLength(8)]
        public string UPDATE_BY { get; set; }
        
        public DateTime? UPDATE_DATE { get; set; }

    }
}
