using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ALaCart.Models
{
    public class Cart
    {

        public int ID { get; set; }

        public List<Order> CustomerOrders { get; set; }

        public string CustomerID { get; set; }
    }
}
