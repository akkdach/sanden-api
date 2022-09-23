using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CATALOG_PROFILE
    {

        [Key]
        [MaxLength(9)]
        public string CAT_PROFILE { get; set; }

        [MaxLength(30)]
        public string DESCRIPTION { get; set; }

        public List<CATALOG_PROFILE_HAS_CATALOG> CAT_CODEGRP { get; set; }

    }
}
