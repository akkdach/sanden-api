using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class VanType
    {
        [Key]
        public int vanTypeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string vanTypeName { get; set; }
        [Required]
        public Boolean vanTypeStatus { get;set; }
    }


}
