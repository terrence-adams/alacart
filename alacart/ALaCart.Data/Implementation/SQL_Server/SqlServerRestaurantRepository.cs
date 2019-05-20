using System;
using System.Collections.Generic;
using System.Text;
using ALaCart.Data.Context;
using ALaCart.Data.Interfaces;
using ALaCart.Models;
using System.Linq;

namespace ALaCart.Data.Implementation.SQL_Server
{
    public class SqlServerRestaurantRepository : IRestaurantRepository
    {
        public ICollection<Restaurant> GetAll()
        {
            using (var context = new ALaCartDbContext())
            {
                return context.Restaurants.ToList();
            }

        }

        public Restaurant GetById(int id)
        {
            using (var content = new ALaCartDbContext())
            {
                var restaurantReturned = content.Restaurants.SingleOrDefault(r => r.ID == id);
                return restaurantReturned;
            }
        }

    }
}
