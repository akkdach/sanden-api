using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WorkOrderRefurbishCheckingList
    {
        [Key]
        public int Id { get; set; }

        public string ORDERID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int CheckListMasterId { get; set; }

        public string Checked { get; set; }

        public string CodeDescription { get; set; }

        public string TextDescription { get; set; }
    }
}
