using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MaterialCostMaster
    {       
        [MaxLength(18)]
        public string MATERIAL { get; set; }

        [MaxLength(40)]
        public string MAT_DESC { get; set; }

        [MaxLength(5)]
        public string TRADE_CODE { get; set; }

        [MaxLength(50)]
        public string TRADE_NAME { get; set; }

        public double UNIT_COST { get; set; }

        public double UNIT_PRICE { get; set; }

        [MaxLength(10)]
        public string CURRENCY { get; set; }
    }
}
