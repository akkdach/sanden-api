using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_CUSTOMER_MAS
    {
        [Key]
        [MaxLength(12)]
        public string ORDERID { get; set; }

        [ForeignKey("ORDERID")]
        public WORK_ORDER WORK_ORDER_OBJ { get; set; }

        [MaxLength(10)]
        public string CUSTOMER { get; set; }

        [MaxLength(2)]
        public string PARTN_ROLE { get; set; }

        [MaxLength(40)]
        public string CUST_NAME { get; set; }

        [MaxLength(20)]
        public string BUILDING { get; set; }

        [MaxLength(40)]
        public string NAME_CO { get; set; }

        [MaxLength(60)]
        public string STREET { get; set; }

        [MaxLength(40)]
        public string CITY1 { get; set; }

        [MaxLength(40)]
        public string CITY2 { get; set; }

        [MaxLength(3)]
        public string REGION { get; set; }

        [MaxLength(10)]
        public string POST_CODE { get; set; }

        [MaxLength(30)]
        public string TEL_NUMBER { get; set; }

        [MaxLength(3)]
        public string COUNTRY { get; set; }

        [MaxLength(10)]
        public string LOCATION_CODE { get; set; }

        [MaxLength(5)]
        public string TRADENAME { get; set; }

        [MaxLength(2)]
        public string CUSTOMER_CLASS { get; set; }

        [MaxLength(7)]
        public string KEYACCOUNT { get; set; }

        public decimal LONGITUDE { get; set; }

        public decimal LATITUDE { get; set; }



        [MaxLength(40)]
        public string TRADDESCP { get; set; }

        [MaxLength(20)]
        public string VTEXT { get; set; }

        [MaxLength(40)]
        public string BRSCH { get; set; }

        [MaxLength(40)]
        public string BRTXT { get; set; }




        [MaxLength(10)]
        public string SERVICE_ZONE { get; set; }

        [MaxLength(3)]
        public string SERVICE_AREA { get; set; }

        [MaxLength(20)]
        public string CUST_TYPE { get; set; }

        [MaxLength(10)]
        public string MATCHINE_GROUP { get; set; }

        [MaxLength(10)]
        public string TYPE_OF_MATCHINE { get; set; }

        [MaxLength(10)]
        public string SERVICE_GROUP { get; set; }

        [MaxLength(10)]
        public string SERVICE_TYPE { get; set; }

        [MaxLength(50)]
        public string SERVICE_TYPE_DESC { get; set; }

        [MaxLength(10)]
        public string CUSTOME_PRICE { get; set; }

        [MaxLength(20)]
        public string BILL_TO_CUST_NO { get; set; }

        [MaxLength(50)]
        public string BILL_TO_CUST_NAME { get; set; }

        [MaxLength(50)]
        public string BILL_TO_ADDR { get; set; }

        [MaxLength(50)]
        public string BILL_TOADDR_2 { get; set; }

        [MaxLength(30)]
        public string BILL_TO_CITY { get; set; }

        [MaxLength(20)]
        public string BILL_TO_POSTCODE { get; set; }


        [MaxLength(6)]
        public string MON_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string MON_MOR_TO { get; set; }

        [MaxLength(6)]
        public string MON_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string MON_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string TUE_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string TUE_MOR_TO { get; set; }

        [MaxLength(6)]
        public string TUE_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string TUE_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string WED_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string WED_MOR_TO { get; set; }

        [MaxLength(6)]
        public string WED_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string WED_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string THU_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string THU_MOR_TO { get; set; }

        [MaxLength(6)]
        public string THU_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string THU_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string FRI_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string FRI_MOR_TO { get; set; }

        [MaxLength(6)]
        public string FRI_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string FRI_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string SAT_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string SAT_MOR_TO { get; set; }

        [MaxLength(6)]
        public string SAT_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string SAT_EVEN_TO { get; set; }


        [MaxLength(6)]
        public string SUN_MOR_FROM { get; set; }

        [MaxLength(6)]
        public string SUN_MOR_TO { get; set; }

        [MaxLength(6)]
        public string SUN_EVEN_FROM { get; set; }

        [MaxLength(6)]
        public string SUN_EVEN_TO { get; set; }
    }
}
