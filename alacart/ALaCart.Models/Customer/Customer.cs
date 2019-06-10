using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALaCart.Models
{
    public class Customer : AppUser
    {


        [MaxLength(30)]
        public string EmailAddress { get; set; }

        /*[Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; } redundant based on default User property*/


        public Address CustomerAddress { get; set; }


    }
}
