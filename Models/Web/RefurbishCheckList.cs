using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class RefurbishCheckList
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Type { get; set; }
        public virtual List<RefurbishItem> Item { get; set; }

        public int Position { get; set; }
        public int RefurbishOrderId { get; set; }
    }
}
