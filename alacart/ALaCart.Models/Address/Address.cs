using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALaCart.Models
{
    public class Address
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        [MaxLength(30)]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string Zipcode { get; set; }


    }
}
