using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class NOTIFICATIONS
    {
        [Key]
        public Guid NOTIFICATION_CODE { get; set; }

        [MaxLength(255)]
        public string NOTIFICATION_TYPE { get; set; }

        [MaxLength(255)]
        public string NOTIFICATION_TITLE { get; set; }

        [MaxLength(255)]
        public string NOTIFICATION_CONTENT { get; set; }

        [MaxLength(255)]
        public string NOTIFICATION_IMAGE { get; set; }
        [MaxLength(255)]
        public string NOTIFICATION_LINK { get; set; }

        [MaxLength(255)]
        public string PLAYER_ID { get; set; }

        [MaxLength(12)]
        public string ORDER_ID { get; set; }

        [MaxLength(255)] 
        public string ONE_SIGNAL_ID { get; set; }

        [MaxLength(8)]
        public bool READED { get; set; }
        [MaxLength(8)]
        public DateTime? READED_DATE { get; set; }
        [MaxLength(8)]
        public DateTime CREATED_DATE { get; set; }
        [MaxLength(255)]
        public string EMPLOYEE_ID { get; set; }
    }
}
