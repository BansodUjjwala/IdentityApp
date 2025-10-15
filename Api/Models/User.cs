using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Api.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public DateTime DateCreated  { get; set; } = DateTime.UtcNow;

       
    }
}
