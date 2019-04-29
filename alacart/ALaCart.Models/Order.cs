﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALaCart.Models
{
    public class Order
    {
        public int ID { get; set; }
        public List<MenuItem> Items { get; set; }

        public Site Site { get; set; }

        [Required]
        public Customer Customer { get; set; }
    }
}
