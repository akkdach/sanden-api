using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class RefurbishItem
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }
        public string type { get; set; }
        public string field_name { get; set; }
        public string code { get; set; }
        public bool display { get; set; }
        public string InputType { get; set; }
        public int Position { get; set; }
        public int RefurbishCheckListId { get; set; }
    }
}
