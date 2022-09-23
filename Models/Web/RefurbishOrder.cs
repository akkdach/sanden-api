using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class RefurbishOrder
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public virtual List<RefurbishCheckList> CheckList { get; set; }

        public int Position { get; set; }
        public int QI_RefurbishId { get; set; }
    }
}
