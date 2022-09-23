using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QUOTA_OT
    {
        [Key]
        public Guid ID { get; set; }

        public int PROVINCE_ID { get; set; }

        [MaxLength(255)]
        public string ORDER_TYPE { get; set; }

        [MaxLength(255)]
        public string SUPERVISOR_CODE { get; set; }

        [MaxLength(4)]
        public int YEAR_ACTIVE { get; set; }

        public decimal? TARGET_ORIGINAL { get; set; }

        public decimal? ORIGINAL_MONTH_1 { get; set; }

        public decimal? ORIGINAL_MONTH_2 { get; set; }

        public decimal? ORIGINAL_MONTH_3 { get; set; }

        public decimal? ORIGINAL_MONTH_4 { get; set; }

        public decimal? ORIGINAL_MONTH_5 { get; set; }

        public decimal? ORIGINAL_MONTH_6 { get; set; }

        public decimal? ORIGINAL_MONTH_7 { get; set; }

        public decimal? ORIGINAL_MONTH_8 { get; set; }

        public decimal? ORIGINAL_MONTH_9 { get; set; }

        public decimal? ORIGINAL_MONTH_10 { get; set; }

        public decimal? ORIGINAL_MONTH_11 { get; set; }

        public decimal? ORIGINAL_MONTH_12 { get; set; }

        public decimal? TARGET_EXTRA { get; set; }

        public decimal? EXTRA_MONTH_1 { get; set; }

        public decimal? EXTRA_MONTH_2 { get; set; }

        public decimal? EXTRA_MONTH_3 { get; set; }

        public decimal? EXTRA_MONTH_4 { get; set; }

        public decimal? EXTRA_MONTH_5 { get; set; }

        public decimal? EXTRA_MONTH_6 { get; set; }

        public decimal? EXTRA_MONTH_7 { get; set; }

        public decimal? EXTRA_MONTH_8 { get; set; }

        public decimal? EXTRA_MONTH_9 { get; set; }

        public decimal? EXTRA_MONTH_10 { get; set; }

        public decimal? EXTRA_MONTH_11 { get; set; }

        public decimal? EXTRA_MONTH_12 { get; set; }

        //[MaxLength(1)]
        //public string? STATUS { get; set; }

        [MaxLength(255)]
        public string CREATE_BY { get; set; }

        public DateTime CREATE_DATE { get; set; }

        [MaxLength(255)]
        public string UPDATE_BY { get; set; }

        public DateTime UPDATE_DATE { get; set; }

        public bool FLAG_DELETE { get; set; }

        [ForeignKey("PROVINCE_ID")]
        public ZONE_MAS zone_mas { get; set; }
    }
}
