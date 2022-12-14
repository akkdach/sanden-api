using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_WORKER
    {
        [Key]
        public int WORK_ORDER_WORKERS_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [MaxLength(4)]
        public string ACTIVITY { get; set; }

        [MaxLength(8)]
        public string PERSONNEL_NUMBER { get; set; }

        [MaxLength(40)]
        public string NAME { get; set; }
    }
}
