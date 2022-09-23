using System.ComponentModel.DataAnnotations;
using System;

namespace sanden_api.Models.Auth
{
    public class Login
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string remember { get; set; }
    }
}
