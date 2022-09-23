using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class SCHEDULE2
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime enter_date { get; set; }
        [Required]
        public string WK_CTR { get; set; }
        [Required]
        public int is_active { get; set; }
        [Required]
        public string start_time { get; set; }
        [Required]
        public string end_time { get; set; }

        public int ot { get; set; }

        public string reason { get; set; }

        public string VAN_SUP { get; set; }

        public DateTime create_date { get; set; }
        [MaxLength(600)]
        public string zones { get; set; }
    }
}
