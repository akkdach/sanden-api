using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CloseingType
    {
        [Key]
        public int ID { get; set; }
        public string ORDER_TYPE { get; set; }
        public string STATUS_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CLOSEING_TYPE { get; set; }
    }
}
