using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class equipment_tntl
    {
        [Key]
        [MaxLength(18)]
        public string EQUIPMENT { get; set; }

        [MaxLength(10)]
        public string OBJECTTYPE { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(4)]
        public string STGE_LOC { get; set; }

        [MaxLength(40)]
        public string USERSTATUS { get; set; }

        [MaxLength(40)]
        public string SYS_STATUS { get; set; }

        [MaxLength(10)]
        public string CUSTOMER { get; set; }

        ///// <summary>
        ///// เพิ่ม 15-12-2021
        [MaxLength(10)]
        public string SHIP_TO_PARTY { get; set; }

        [MaxLength(50)]
        public string SHIP_NAME { get; set; }
        ///// </summary>

        [MaxLength(40)]
        public string CUST_NAME { get; set; }

        [MaxLength(12)]
        public string ASSET_NO { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        ///// <summary>
        ///// เพิ่ม 15-12-2021
        [MaxLength(50)]
        public string MATERIAL_DESC { get; set; }
        ///// </summary>

        [MaxLength(40)]
        public string MAKTX { get; set; }

        [MaxLength(10)]
        public string CDE_CODE { get; set; }

        ///// <summary>
        ///// เพิ่ม 15-12-2021
        [MaxLength(30)]
        public string IMEI { get; set; }
        ///// </summary>

        [MaxLength(30)]
        public string ZZIMEI_CON_DEVICE { get; set; }

        [MaxLength(30)]
        public string ZZSIM_MOBILE_NUMBER { get; set; }

        [MaxLength(30)]
        public string ZZSIM_ICCID { get; set; }

        [MaxLength(30)]
        public string ZZSIM_SERVICE_PROVIDER { get; set; }

        [MaxLength(30)]
        public string ZZCON_DEVICE_TYPE { get; set; }

        [MaxLength(25)]
        public string INVENTORY_NUMBER { get; set; }

        [MaxLength(50)]
        public string LOCATION { get; set; }

        [MaxLength(10)]
        public string CUSTOMER_GROUP { get; set; }

        [MaxLength(20)]
        public string START_DATE { get; set; }
        ///// <summary>
        ///// เพิ่ม 15-12-2021
        [MaxLength(50)]
        public string DISTRICT { get; set; }
        ///// </summary>

        [MaxLength(40)]
        public string CITY1 { get; set; }

        [MaxLength(40)]
        public string CITY2 { get; set; }

        [MaxLength(40)]
        public string BPA_ZONE { get; set; }

        [MaxLength(10)]
        public string CURRENT_CUSTOMER { get; set; }

    }
}
