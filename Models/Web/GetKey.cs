using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BevProFSServiceAPI.Models.Entity
{
    public class GetKey
    {
        [Key]
        public string Key { get; set; }
    }
}
