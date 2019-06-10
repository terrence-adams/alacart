using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALaCart.Models
{
    public class Menu
    {

        public int ID { get; set; }

        public List<MenuItem> MenuItems { get; set; }

        public Restaurant Restaurant { get; set; }

        [Required]
        public int RestaurantId { get; set; }


    }
}
