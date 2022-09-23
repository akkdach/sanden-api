using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class BillControl
    {
        [Key]
        public string BillNo { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? BillDate { get; set; }

        public string Order { get; set; }

        public string omCustomer { get; set; }

        public string NameCustomer { get; set; }

        public string BillBy { get; set; }

        public double? SalesPrice { get; set; }

        public string Remark { get; set; }

        public DateTime? workerToAccountBillDate { get; set; }
        public DateTime? accountReceiveBillDate { get; set; }
        public bool IsUsed { get; set; } = false;
       
    }
}
