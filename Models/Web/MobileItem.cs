using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class MobileItem
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Type { get; set; }
        public string Field_name { get; set; }
        public string Code { get; set; }
        public bool Display { get; set; }
        public string InputType { get; set; }
        public int Position { get; set; }
        public int MobileDetailId { get; set; }
    }
}
