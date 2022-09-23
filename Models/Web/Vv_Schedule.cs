using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class vv_schedule
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime enter_date { get; set; }
        public string wK_CTR { get; set; }
        public int is_active { get; set; }
        public string? start_time { get; set; }
        public string? end_time { get; set; }

        public int ot { get; set; }

        public int reason { get; set; }

        public string VAN_SUP { get; set; }

        public DateTime create_date { get; set; }
        public string? zones { get; set; }
        public string? vanType { get; set; }
        public vv_schedule()
        {

            this.enter_date = DateTime.Now;
            this.wK_CTR = "";
            this.VAN_SUP = "";
            this.start_time = "";
            this.end_time = "";
            this.is_active = 0;
            this.zones = "";
            this.vanType = "";
            this.ot=0;
            this.reason= 0;
        }
    }

   public class scheduleMobileList
    {
      public DateTime enter_date { get; set; }
      public string van_no { get;set; }
      public int is_active { get; set; }
      public string start_time { get; set; }
      public string end_time { get;set;}
      public int ot { get; set; }
      public int reason { get; set; }
      public List<string> van_type { get; set; }
      public string zone { get; set; }
    }
}
