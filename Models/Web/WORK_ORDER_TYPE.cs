using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_TYPE
    {
        [Key]
        [Display(Name = "Order Type")]
        public string ORDER_TYPE { get; set; }

        [MaxLength(40)]
        public string SHORT_TEXT { get; set; }

        [MaxLength(50)]
        public string DESCRIPTION { get; set; }

        [MaxLength(255)]
        public string TARGET_OT { get; set; }
        [MaxLength(255)]
        public string TARGET_OT_UNIT { get; set; }

    }
}
