using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class STORAGE_LOCATION
    {

        [Key]
        public int STORAGE_LOCATION_ID { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(4)]
        public string STGE_LOC { get; set; }

        [MaxLength(16)]
        public string DESCRIPTION { get; set; }

    }
}
