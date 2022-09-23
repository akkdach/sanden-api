using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MASTER_QUALITY_DEFECT
    {
        [Key]
        [MaxLength(3)]
        public string QUALITY_DEFECT_CODE { get; set; }
        public string QUALITY_DEFECT { get; set; }
        public string GROUP_QUALITY { get; set; }
    }
}
