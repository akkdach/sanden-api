using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QI_Refurbish
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public virtual List<RefurbishOrder> QiRefurbishOrderList { get; set; }

    }
}
