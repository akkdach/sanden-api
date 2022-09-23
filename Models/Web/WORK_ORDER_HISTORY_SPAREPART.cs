using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_HISTORY_SPAREPART
    {
        [Key]
        public int WORK_ORDER_HISTORY_SPAREPART_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID_HISTORY { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(40)]
        public string MATL_DESC { get; set; }

        public decimal QUANTITY { get; set; }

        [MaxLength(3)]
        public string UNIT { get; set; }
    }
}
