using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_VAN_SUP
    {
        [Key]
        public Guid ID { get; set; }

        [MaxLength(8)]
        public string WK_CTR_SUP { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACTUAL_START_DATE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACTUAL_FINISH_DATE { get; set; }

        [MaxLength(255)]
        public string CREATE_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CREATE_DATE { get; set; }

        [MaxLength(255)]
        public string UPDATE_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? UPDATE_DATE { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER ORDER_REF { get; set; }
    }
}
