using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class work_order_replace
    {
        [Key]
        [MaxLength(12)]
        public string ORDERID { get; set; }

        [MaxLength(10)]
        public string CUSTOMER { get; set; }

        [MaxLength(40)]
        public string CUST_NAME { get; set; }

        [MaxLength(8)]
        public string CUST_TYPE { get; set; }

        [MaxLength(40)]
        public string IDENTITY_CODE { get; set; }
        public DateTime? IDENTITY_EXPIRE { get; set; }

        [MaxLength(30)]
        public string TEL_NUMBER { get; set; }

        [MaxLength(255)]
        public string IDENTITY_IMAGE_URL { get; set; }

        [MaxLength(255)]
        public string SHOP_IMAGE_URL { get; set; }

        [MaxLength(255)]
        public string MAP_IMAGE_URL { get; set; }

        [MaxLength(255)]
        public string OTHER_IMAGE_URL { get; set; }

        [MaxLength(40)]
        public string CONTACT_NAME { get; set; }

        [MaxLength(30)]
        public string CONTACT_TEL_NUMBER { get; set; }

        [MaxLength(255)]
        public string SIGNATURE_URL { get; set; }
        public DateTime? SIGNATURE_DATE { get; set; }

        [MaxLength(255)]
        public string EMPLOYEE_ID { get; set; }

        [MaxLength(20)]
        public string IDENTITY_EXPIRE_DESC { get; set; }
    }
}
