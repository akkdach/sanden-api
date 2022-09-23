using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_NOTIFICATION_HEADER
    {
        [Key]
        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(4)]
        public string NOTIF_CODE { get; set; }

        [MaxLength(8)]
        public string NOTIF_CODEGROUP { get; set; }

        [MaxLength(80)]
        public string NOTIF_CODE_TEXT { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NOTIF_DATE { get; set; }

        [MaxLength(18)]
        public string NOTIF_EQUIPMENT { get; set; }

        [MaxLength(35)]
        public string NOTIF_INCIDENT { get; set; }

        [MaxLength(3000)]
        public string NOTIF_LONGTEXT { get; set; }

        [MaxLength(12)]
        public string NOTIF_NO { get; set; }

        [MaxLength(12)]
        public string NOTIF_REPORT_BY { get; set; }

        [MaxLength(8)]
        public string NOTIF_TIME { get; set; }

        [MaxLength(2)]
        public string NOTIF_TYPE { get; set; }

        [MaxLength(1)]
        public string EQUIPMENT_WORKABLE { get; set; }

        [MaxLength(35)]
        public string ZZRF_INCIDENT { get; set; }

        [MaxLength(35)]
        public string ZZPROJECT { get; set; }

        [MaxLength(3)]
        public string ZZFIRST { get; set; }

        [MaxLength(3)]
        public string ZZFIRST_SET { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ZZPREFERDATE { get; set; }

        //Update Field 2021/07/08
        [DataType(DataType.Date)]
        public DateTime? WARRANTY_STR_DATE_PART { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WARRANTY_END_DATE_PART { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WARRANTY_STR_DATE_LABOUR { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WARRANTY_END_DATE_LABOUR { get; set; }

        [MaxLength(1)]
        public string WARRNTY { get; set; }

        [MaxLength(20)]
        public string CONTRACT_NO { get; set; }

        [MaxLength(1)]
        public string SERVICE_CONTRACT { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SERVICE_WARRANTY_DAY { get; set; }

        public decimal? WARRANTY_DISCOUNT_PART { get; set; }
    
        public decimal? WARRANTY_DISCOUNT_LABOUR { get; set; }

        public decimal? CONTRACT_DISCOUNT { get; set; }

        public List<WORK_ORDER_NOTIFICATION_DOC_LINK> DOC_LINK;
    }
}
