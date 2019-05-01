using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ALaCart.Models
{
    public class MenuItem
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
