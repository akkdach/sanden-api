using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_OPERATION
    {

        [Key]
        public int WORK_ORDER_OPERATION_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(4)]
        public string ACTIVITY { get; set; }

        [MaxLength(4)]
        public string CONTROL_KEY { get; set; }

        [MaxLength(8)]
        public string WORK_CNTR { get; set; }

        [ForeignKey("WORK_CNTR")]
        public WORK_CENTER WORK_CENTER { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(40)]
        public string DESCRIPTION { get; set; }

        public int NUMBER_OF_CAPACITIES { get; set; }

        [MaxLength(6)]
        public string ACTTYPE { get; set; }

        public decimal DURATION_NORMAL { get; set; }

        [MaxLength(3)]
        public string DURATION_NORMAL_UNIT { get; set; }

        public decimal WORK_ACTIVITY { get; set; }

        [MaxLength(3)]
        public string UN_WORK { get; set; }

        [MaxLength(10)]
        public string CONF_NO { get; set; }

        public decimal WORK_ACTUAL { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACT_START_DATE { get; set; }

        [MaxLength(8)]
        public string ACT_START_TIME { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACT_END_DATE { get; set; }

        [MaxLength(8)]
        public string ACT_END_TIME { get; set; }

        [MaxLength(40)]
        public string SYSTEM_STATUS_TEXT { get; set; }

        [MaxLength(8)]
        public string WORK_ACTUAL_START { get; set; }

        [MaxLength(8)]
        public string WORK_ACTUAL_FINISH { get; set; }

    }
}
