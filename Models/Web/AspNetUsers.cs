using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class AspNetUsers
    {
        [Key]
        public string Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public bool? LockoutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public string Name { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string ProfileImageUrl { get; set; }
        public string SecurityStamp { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public string UserName { get; set; }
        public string WK_CTR { get; set; }
        public string DEVICE_TOKEN { get; set; }
        public string EMPLOYEE_ID { get; set; }
        public string TELEPHONE { get; set; }
        public string SIGNATURE_URL { get; set; }
    }
}
