using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class ServiceCostMaster
    {
        [MaxLength(10)]
        public string COST_NO { get; set; }

        [MaxLength(40)]
        public string COST_DESC { get; set; }

        [MaxLength(10)]
        public string COST_TYPE { get; set; }

        [MaxLength(10)]
        public string TRADE_CODE { get; set; }

        [MaxLength(10)]
        public string TRADE_NAME { get; set; }

        public int QUANTITY { get; set; }

        public double UNIT_COST { get; set; }

        public double UNIT_PRICE { get; set; }

        [MaxLength(10)]
        public string CURRENCY { get; set; }

        [MaxLength(10)]
        public string SERVICE_ZONE_CODE { get; set; }

        [MaxLength(20)]
        public string SERVICE_ZONE_DESCRIPTION { get; set; }

        [MaxLength(15)]
        public string STANDARD_TIME { get; set; }

        [MaxLength(8)]
        public string ORDERTIME_START { get; set; }

        [MaxLength(8)]
        public string ORDERTIME_END { get; set; }
    }
}
