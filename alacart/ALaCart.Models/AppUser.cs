using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace ALaCart.Models
{
    class AppUser : IdentityUser
    {
        //will define as base user class customer/restaurant/admin
    }
}
