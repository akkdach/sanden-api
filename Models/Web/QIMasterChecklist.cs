using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QIMasterChecklist
    {
        [Key]
        public string QIMobileType { get; set; }

        public int seq { get; set; }

        public Boolean display { get;set; }

        public string inputType { get; set; }   

        public string title { get; set; }

        public string Type { get; set; }

        //public virtual List<MobileDetail> CheckList { get; set; }
    }
}
