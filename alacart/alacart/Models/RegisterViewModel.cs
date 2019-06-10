using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALaCart.Models
{
    public class RegisterViewModel
    {
        [Phone, Required]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password), Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<IdentityRole> Roles { get; set; }

        public string Role { get; set; }
    }
}
