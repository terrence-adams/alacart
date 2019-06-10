using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ALaCart.Models
{
    public class MenuItem
    {

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
