using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MobileCheckList
    {
        [Key]
        public string Code { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

    }
}
