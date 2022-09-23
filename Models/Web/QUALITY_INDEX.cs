using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QUALITY_INDEX
    {
        [Key]
        public int QUALITY_CODE { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }      
        
        [MaxLength(3)] 
        public string QUALITY_TYPE { get; set; }

        public int? QUALITY_CHECK { get; set; }

        public int? QUALITY_PASS { get; set; }

        public decimal? QUALITY_PERCENT { get; set; }
    }
}
