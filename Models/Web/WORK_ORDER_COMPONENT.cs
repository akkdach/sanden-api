using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_COMPONENT
    {
        [Key]
        public int WORK_ORDER_COMPONENT_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(10)]
        public string RESERV_NO { get; set; }

        [MaxLength(4)]
        public string RES_ITEM { get; set; }

        [MaxLength(1)]
        public string MOVEMENT { get; set; }

        [MaxLength(1)]
        public string WITHDRAWN { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(4)]
        public string STGE_LOC { get; set; }

        [MaxLength(10)]
        public string BATCH { get; set; }

        [MaxLength(10)]
        public string GL_ACCOUNT { get; set; }

        [MaxLength(1)]
        public string ITEM_CAT { get; set; }

        [MaxLength(4)]
        public string ITEM_NUMBER { get; set; }

        [MaxLength(4)]
        public string ACTIVITY { get; set; }

        public decimal PRICE { get; set; }

        public decimal PRICE_UNIT { get; set; }

        [MaxLength(3)]
        public string PUR_GROUP { get; set; }

        [MaxLength(9)]
        public string MATL_GROUP { get; set; }

        [MaxLength(40)]
        public string MATL_DESC { get; set; }

        public decimal REQUIREMENT_QUANTITY { get; set; }

        [MaxLength(3)]
        public string REQUIREMENT_QUANTITY_UNIT { get; set; }

        [DataType(DataType.Date)]
        public DateTime? REQ_DATE { get; set; }

        [MaxLength(8)]
        public string REQ_TIME { get; set; }

        [MaxLength(3)]
        public string MOVE_TYPE { get; set; }

        public Decimal COMMITED_QUAN { get; set; }

        [MaxLength(1)]
        public string WARRANTY_CHECK { get; set; }

        public decimal? ACTUAL_QUANTITY { get; set; }

        [MaxLength(3)]
        public string ACTUAL_QUANTITY_UNIT { get; set; }
    }
}
