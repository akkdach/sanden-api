using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class SCHEDULE
    {
        [Key]
        public int id { get; set; }
        public DateTime enter_date { get; set; }
        public string WK_CTR { get; set; }
        public int is_active { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public int ot { get; set; }
        public int reason { get; set; }
        public string VAN_SUP { get; set; }
        public DateTime create_date { get; set; }
        public string zones { get; set; }
        public string? vanType { get; set; }

    }

    public class scheduleReason
    {
        [Key]
        public int value { get; set; }
        public string label { get;set; }
    }

    public class ScheduleForm
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime enter_date { get; set; }
        public string? van_no { get; set; }
        public int is_active { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public int ot { get; set; }
        public int reason { get; set; }
        public string? VAN_SUP { get; set; }
        public DateTime? create_date { get; set; }
        public string? zone { get; set; }
        public List<int> vanType { get; set; }

        public string setVanType()
        {
            string result = "";
            if (this.vanType != null)
            {
                result = String.Join(",", this.vanType);
            }
            return result;
        }

        public List<string> getVanType(string str)
        {
            List<string> result = str.Split(',').ToList();
            return result;
        }
    }


}
