using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ALaCart.Models
{
    public class Cart
    {
        [Required]
        public int ID { get; set; }
    }
}
