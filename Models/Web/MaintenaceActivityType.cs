using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MaintenaceActivityType
    {
        [Key]
        public int Id { get; set; }

        public string OrderType { get; set; }
        public string MaintenaceActivity { get; set; }
        public string Descriiption { get; set; }
    }
}
