using System;
using System.Collections.Generic;
using System.Text;


namespace ALaCart.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Menu> RestaurantMenus { get; set; }


    }
}
