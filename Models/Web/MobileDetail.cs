using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MobileDetail
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Type { get; set; }
        public virtual List<MobileItem> Item { get; set; }

        public int Position { get; set; }
        public int QI_MOBILEId { get; set; }
        public bool Display { get; set; }

    }
}
