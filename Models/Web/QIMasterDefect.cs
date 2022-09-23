using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QIMasterDefect
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
    }
}
