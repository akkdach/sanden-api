using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WORK_ORDER_NOTIFICATION_DOC_LINK
    {

        [Key]
        public int WORK_ORDER_NOTIFICATION_DOC_LINK_ID { get; set; }

        [MaxLength(12)]
        public string NOTIF_NO { get; set; }

        [MaxLength(3)]
        public string DOC_TYPE { get; set; }

        [MaxLength(25)]
        public string DOC_NO { get; set; }

        [MaxLength(255)]
        public string DOC_URL { get; set; }

    }
}
