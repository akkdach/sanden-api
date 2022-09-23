using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class TransferRoute
    {
        [Key]
        [MaxLength(8)]
        public string TRANSFER_FROM { get; set; }

        [MaxLength(8)]
        public string TRANSFER_TO { get; set; }

        [MaxLength(4)]
        public string IN_TRANSIT_CODE { get; set; }
    }
}
