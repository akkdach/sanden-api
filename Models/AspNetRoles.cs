﻿using System.ComponentModel.DataAnnotations;

namespace sanden_api.Models
{
    public class AspNetRoles
    {
        [Key]
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }  
        public string? ConcurrencyStamp { get; set; }
    }
}
