using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_PM_CHECKING_LIST
    {
        [Key]
        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(1)]
        public string PM_CHECK1 { get; set; }

        [MaxLength(1)]
        public string PM_CHECK2 { get; set; }

        [MaxLength(1)]
        public string PM_CHECK3 { get; set; }

        [MaxLength(1)]
        public string PM_CHECK4 { get; set; }

        [MaxLength(1)]
        public string PM_CHECK5 { get; set; }

        [MaxLength(255)]
        public string PM_CHECK1_REMARK { get; set; }

        [MaxLength(255)]
        public string PM_CHECK2_REMARK { get; set; }

        [MaxLength(255)]
        public string PM_CHECK3_REMARK { get; set; }

        [MaxLength(255)]
        public string PM_CHECK4_REMARK { get; set; }

        [MaxLength(255)]
        public string PM_CHECK5_REMARK { get; set; }

        [MaxLength(255)]
        public string CommentedUserType { get; set; }
    }
}
