using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QUALITY_DEFECT
    {
        [Key]
        public int QUALITY_DEFECT_CODE { get; set; }

        public int QUALITY_CODE { get; set; }

        [MaxLength(4)]
        public string DEFECT_CODE { get; set; }

        [ForeignKey("DEFECT_CODE")]
        public MASTER_QUALITY_DEFECT masterQualityDefect { get; set; }

        [NotMapped]
        public int Position_QI { get; set; }
    }
}
