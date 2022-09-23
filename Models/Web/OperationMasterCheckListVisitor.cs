using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class OperationMasterCheckListVisitor
    {
        [Key]
        public int Id { get; set; }

        public string Label { get; set; }

        public string Value { get; set; }
    }
}
