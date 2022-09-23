using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class STORAGE_LOCATION_STOCK
    {
        [Key]
        public int STORAGE_LOCATION_STOCK_ID { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(4)]
        public string STGE_LOC { get; set; }

        [MaxLength(16)]
        public string STGE_DESC { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(40)]
        public string MAT_DESC { get; set; }

        public decimal QUOTA_STOCK { get; set; }

        public decimal ON_WITHDRAW { get; set; }

        public decimal ZNEW { get; set; }

        public decimal ZREFURB { get; set; }

        [ForeignKey("MATERIAL")]
        public MATERIAL_MASTER MaterialMaster { get; set; }

    }
}
