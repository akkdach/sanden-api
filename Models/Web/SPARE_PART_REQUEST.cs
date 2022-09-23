using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class SPARE_PART_REQUEST
    {

        [Key]
        public int RES_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(8)]
        public string WK_CTR { get; set; }

        [ForeignKey("WK_CTR")]
        public WORK_CENTER WORK_CENTER_OBJ { get; set; }

        [MaxLength(8)]
        public string ASSIGNED_WK_CTR { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RES_DATE { get; set; }

        [MaxLength(3)]
        public string MOVE_TYPE { get; set; }

        [MaxLength(4)]
        public string MOVE_PLANT { get; set; }

        [MaxLength(4)]
        public string MOVE_STLOC { get; set; }

        [MaxLength(1)]
        public int? WEB_STATUS { get; set; }

        [MaxLength(20)]
        public string RESERVATION_NO { get; set; }

        [MaxLength(8)]
        public string FROM_VAN { get; set; }

        [MaxLength(1)]
        public string FINAL_GR { get; set; }

        [MaxLength(1)]
        public string POST_SHIP { get; set; }

        [MaxLength(1)]
        public string MaterialType { get; set; }

        public List<SPARE_PART_REQUEST_ITEM> spare_part_request_item { get; set; }

    }
}
