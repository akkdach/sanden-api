using System.ComponentModel.DataAnnotations;
using System;
namespace sanden_api.Models
{
    public class Users
    {
        [Key]
        public string username { get; set; }    
        public string password { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int companyId { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string createBy { get; set; }
        public DateTime? createAt { get; set; }
    }
}
