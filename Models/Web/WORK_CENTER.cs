using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_CENTER
    {

        [Key]
        [MaxLength(8)]
        public string WK_CTR { get; set; }

        [MaxLength(4)]       
        public string PLANT { get; set; }

        [MaxLength(40)]
        public string DESCRIPTION { get; set; }

        public string START_TIME { get; set; }

        public string FINISH_TIME { get; set; }

        public string BREAK_TIME { get; set; }

        public string LENGTH { get; set; }

        public string WIDTH { get; set; }

        public string HEIGHT { get; set; }

        public string OT { get; set; }

        public string ZONE { get; set; }

        public string VAN_SUP { get; set; }

    }

    public class Vv_Work_Center
    {
        [Key]
        [MaxLength(8)]
        public string WK_CTR { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(40)]
        public string DESCRIPTION { get; set; }

        public string START_TIME { get; set; }

        public string FINISH_TIME { get; set; }

        public string BREAK_TIME { get; set; }

        public string LENGTH { get; set; }

        public string WIDTH { get; set; }

        public string HEIGHT { get; set; }

        public string OT { get; set; }

        public string ZONE { get; set; }

        public string VAN_SUP { get; set; }
        public virtual vv_schedule schedule { get; set; }
    }
}
