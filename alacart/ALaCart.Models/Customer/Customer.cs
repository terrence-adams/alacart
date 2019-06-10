﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALaCart.Models
{
    public class Customer : IdentityUser
    {

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }


        [MaxLength(30)]
        public string EmailAddress { get; set; }

        /*[Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }*/


        public Address CustomerAddress { get; set; }


    }
}
