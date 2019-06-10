using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace ALaCart.Models
{
    public class AppUser : IdentityUser
    {
        //will define as base user class customer/restaurant/admin

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

    }
}
