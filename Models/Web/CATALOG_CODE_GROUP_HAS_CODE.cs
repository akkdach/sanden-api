using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CATALOG_CODE_GROUP_HAS_CODE
    {

        [Key]
        public int CATALOG_CODE_GROUP_HAS_CODE_ID { get; set; }

        public string CATALOG { get; set; }

        public string CODE_GROUP { get; set; }

        public string CODE { get; set; }

        public string SHORT_TEXT { get; set; }

        public int CATALOG_PROFILE_HAS_CATALOG_ID { get; set; }

    }
}
