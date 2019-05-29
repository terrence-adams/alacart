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

        public Restaurant RestaurantOfMenu { get; set; }

        public string RestaurantIdOfMenu { get; set; }


    }
}
