using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALaCart.Models
{
    public class Site
    {

        public int ID { get; set; }

        [Required]
        public string SiteName { get; set; }

        public Address SiteAddress { get; set; }

        public List<Restaurant> Restaurants { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Customer> Customers { get; set; }

        public string RestaurantID { get; set; }





    }
}
