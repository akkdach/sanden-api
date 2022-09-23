using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class VisitInspectorImageCheckingList
    {
        [Key]
        public int Id { get; set; }

        public string OrderId { get; set; }

        public int HeaderCheckListId { get; set; }

        public string FileName { get; set; }

        public int? FileSize { get; set; }

        public int? Height { get; set; }

        public string Type { get; set; }

        public int? Width { get; set; }

        public string FormatType { get; set; }

        public string ImageUrl { get; set; }

        [MaxLength(10)]
        public string WorkType { get; set; }
    }
}
