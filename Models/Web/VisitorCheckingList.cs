using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class VisitorCheckingList
    {
        [Key]
        public int Id { get; set; }

        public string Measure { get; set; }
        public string Label { get; set; }
        public int order { get; set; }

        public string OrderId { get; set; }
        public string work_type { get; set; }
        public string remark { get; set; }
    }
}
