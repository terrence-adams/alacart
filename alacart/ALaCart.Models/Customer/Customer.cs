using System;
using System.Collections.Generic;
using System.Text;

namespace ALaCart.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public Cart CustomerCart { get; set; }

        public Address CustomerAddress { get; set; }


    }
}
