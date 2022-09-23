using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class LOG_CLOSE_WORKORDER
    {
        [Key]
        public int Id { get; set; }

        public string ORDERID { get; set; }
        public string CalledBy { get; set; }
        public DateTime CalledDate { get; set; }

        public string LastTimaIsCalled { get; set; }
        public int CountIsCalled { get; set; }


    }
}
