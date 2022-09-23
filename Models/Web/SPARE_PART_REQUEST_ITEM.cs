using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class SPARE_PART_REQUEST_ITEM
    {

        [Key]
        public int RES_ITEM_ID { get; set; }

        public int RES_ID { get; set; }

        [ForeignKey("RES_ID")]
        public SPARE_PART_REQUEST SPARE_PART_REQUEST_OBJ { get; set; }

        [MaxLength(8)]
        public string WK_CTR { get; set; }

        [ForeignKey("WK_CTR")]
        public WORK_CENTER WORK_CENTER_OBJ { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(4)]
        public string STGE_LOC { get; set; }

        [MaxLength(10)]
        public string BATCH { get; set; }

        [MaxLength(10)]
        public string VAL_TYPE { get; set; }

        public decimal ENTRY_QNT { get; set; }

        [MaxLength(1)]
        public string MOVEMENT { get; set; }

    }
}
