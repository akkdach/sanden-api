using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MATERIAL_MASTER
    {

        [Key]
        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(40)]
        public string DESCRIPTION { get; set; }

        public string PICTURE_URL { get; set; }

        [MaxLength(3)]
        public string UNIT { get; set; }

    }
}
