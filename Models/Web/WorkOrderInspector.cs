using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class WorkOrderInspector
    {
        [Key]
        public int Id { get; set; }

        public string DocumentNo { get; set; }
        public string VanSupervisor { get; set; }
        public string ScheFinish { get; set; }
        public string ServiceOrderType { get; set; }
        public string CustomerNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string City2 { get; set; }
        public string ObjectTypeToMobile { get; set; }
        public string ActualFinishDate { get; set; }
        
        [NotMapped]
        public int? WebStatus { get; set; }
    }
}
