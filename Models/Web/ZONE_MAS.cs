using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class ZONE_MAS
    {
        [Key]
        public int PROVINCE_ID { get; set; }

        [MaxLength(100)]
        public string PROVINCE { get; set; }

        [MaxLength(20)]
        public string ZONE { get; set; }
    }
}
