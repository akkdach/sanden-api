using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_HISTORYORDER_HEADER
    {
        [Key]
        public int WORK_ORDER_HISTORYORDER_HEADER_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [MaxLength(12)]
        public string ORDERID_HISTORY { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(10)]
        public string CUSTOMER { get; set; }

        [MaxLength(12)]
        public string NOTIF_NO { get; set; }

        [MaxLength(3000)]
        public string NOTIF_LONGTEXT { get; set; }

        [MaxLength(4)]
        public string ORDER_TYPE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NOTIF_DATE { get; set; }

        [MaxLength(8)]
        public string NOTIF_TIME { get; set; }

        [MaxLength(35)]
        public string NOTIF_INCIDENT { get; set; }

        [MaxLength(18)]
        public string EQUIPMENT { get; set; }

        [MaxLength(8)]
        public string NOTIF_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string NOTIF_CODE { get; set; }

        [MaxLength(80)]
        public string NOTIF_CODE_TEXT { get; set; }

        [MaxLength(8)]
        public string NOTIF_OBJPART_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string NOTIF_OBJPART_CODE { get; set; }

        [MaxLength(80)]
        public string NOTIF_OBJPART_TEXT { get; set; }

        [MaxLength(8)]
        public string NOTIF_PROBLEM_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string NOTIF_PROBLEM_CODEG { get; set; }

        [MaxLength(80)]
        public string NOTIF_PROBLEM_TEXT { get; set; }

        [MaxLength(8)]
        public string NOTIF_CAUSE_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string NOTIF_CAUSE_CODEG { get; set; }

        [MaxLength(80)]
        public string NOTIF_CAUSE_TEXT { get; set; }

        [MaxLength(8)]
        public string NOTIF_ACT_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string NOTIF_ACT_CODEG { get; set; }

        [MaxLength(80)]
        public string NOTIF_ACT_TEXT { get; set; }

        public List<WORK_ORDER_HISTORY_SPAREPART> HISTORY_SPAREPART { get; set; }
    }
}
