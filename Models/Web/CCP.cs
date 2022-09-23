using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class CCP
    {

        [Key]
        [MaxLength(18)]
        public string EQUIPMENT { get; set; }

        [MaxLength(100)]
        public string CREATED_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CREATE_DATE { get; set; }

    }
}
