using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class STDTravelMaster
    {
        [Key]
        [MaxLength(18)]
        public string Code { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string Plans { get;set; }
        [MaxLength(100)]
        [Required]
        public string Deppo { get; set; }
        [MaxLength(100)]
        [Required]
        public string ServiceArea { get; set; }
        public double AverageTime { get; set; }
        public DateTime? Create_date { get; set; }
    }
}
