using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class NOTIFICATIONS_DEVICE
    {
        [Key]
        public int Id { get; set; }

        public string PlayerId { get; set; }
        public string TopicHeader { get; set; }
        public string Type { get; set; }
        public bool IsReaded { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ReadedDate { get; set; }
    }
}
