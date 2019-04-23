using System;
using System.Collections.Generic;
using System.Text;

namespace ALaCart.Models
{
    public class Site
    {
        public int ID { get; set; }

        public string SiteName { get; set; }

        public Address SiteAddress { get; set; }

        public List<Restaurant> Restaurants { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Customer> Customers { get; set; }




    }
}
