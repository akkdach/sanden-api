using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_LOG
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        public DateTime CREATE_DATETIME { get; set; }

        public int? MILEAGE { get; set; }

        [MaxLength(255)]
        public string WK_CTR { get; set; }

        [MaxLength(1)]
        public int? INIT_FLAG { get; set; }

        [MaxLength(1)]
        public int? WORK_ACTION { get; set; }
    }
}
