using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CATALOG_PROFILE_HAS_CATALOG
    {
        [Key]
        public int CATALOG_PROFILE_HAS_CATALOG_ID { get; set; }

        public string CAT_PROFILE { get; set; }

        public string CATALOG { get; set; }

        public string CODE_GROUP { get; set; }

        public List<CATALOG_CODE_GROUP_HAS_CODE> CODEGRP { get; set; }
    }
}
