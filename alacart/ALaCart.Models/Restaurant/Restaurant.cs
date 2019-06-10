using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace ALaCart.Models
{
    public class Restaurant
    {

        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Display(Name = "Menu")]
        public List<Menu> RestaurantMenus { get; set; }

        public int RestaurantMenuID { get; set; }


        public List<Order> RestaurantOrders { get; set; }


    }
}
