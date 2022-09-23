using System.ComponentModel.DataAnnotations;
using System;
namespace sanden_api.Models.Auth
{
    public class LoginResult
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string fname { get; set; }
        public string lname { get; set; }
        public int companyId { get; set; }
        public string role { get; set; }

        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerContactName { get; set; }
        public string customerContactNumber { get; set; }
        public string customerEmail { get; set; }
        public string branchId { get; set; }
        public string branchName { get; set; }
        public string taxId { get; set; }
        public string logo { get; set; }
        public string tradCode { get; set; }
        public string customerCodeWeb { get; set; }
    }
}
