using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CATALOG_CODE_ACTUAL
    {

        [Key]
        public int ACTUAL_ID { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(12)]
        public string NOTIF_NO { get; set; }

        [MaxLength(8)]
        public string PROBLEM_CODEGROUP { get; set; }

        [MaxLength(4)]
        public int POSNR { get; set; }

        [MaxLength(4)]
        public string PROBLEM_CODE { get; set; }

        [MaxLength(8)]
        public string DAMAGE_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string DAMAGE_CODE { get; set; }

        [MaxLength(40)]
        public string DAMAGE_TEXT { get; set; }

        [MaxLength(8)]
        public string CAUSE_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string CAUSE_CODE { get; set; }

        [MaxLength(40)]
        public string CAUSE_TEXT { get; set; }

        [MaxLength(8)]
        public string ACTIVITY_CODEGROUP { get; set; }

        [MaxLength(4)]
        public string ACTIVITY_CODE { get; set; }

        [MaxLength(40)]
        public string ACTIVITY_TEXT { get; set; }

    }
}
