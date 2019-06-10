using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ALaCart.Models;
using ALaCart.Data.Interfaces;
using ALaCart.Data.Context;

namespace ALaCart.Data.Implementation.SQL_Server
{
    public class SqlServerSiteRepository : ISiteRepository
    {
        public Restaurant Create(Restaurant newRestaurant)
        {
            using (var context = new ALaCartDbContext())
            {
                context.Restaurants.Add(newRestaurant);
                context.SaveChanges();
            }

            return newRestaurant;
        }

        public bool Delete(int iD)
        {
            using (var context = new ALaCartDbContext())
            {
                var deletedRestaurant = GetById(iD);
                context.Restaurants.Remove(deletedRestaurant);
                context.SaveChanges();

                if (GetById(iD) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public Restaurant GetById(int id)
        {
            Restaurant restaurantFound;
            using (var context = new ALaCartDbContext())
            {
                restaurantFound = context.Restaurants.Find(id);
            }

            return restaurantFound;
        }

        public Restaurant Update(Restaurant oldRestaurant)
        {
            using (var context = new ALaCartDbContext())
            {
                var updatedRestaurant = GetById(oldRestaurant.ID);
                context.Entry(updatedRestaurant)
                    .CurrentValues
                    .SetValues(oldRestaurant);
                context.SaveChanges();
            }

            return oldRestaurant;
        }


        public ICollection<Restaurant> GetAllRestaurants()
        {

            using (var context = new ALaCartDbContext())
            {
                return context.Restaurants.ToList();
            }

        }


        public ICollection<Restaurant> GetAllRestaurantsById(string restaurantId)
        {

            using (var context = new ALaCartDbContext())
            {
                return context.Restaurants
                    .Where(r => r.ID == int.Parse(restaurantId)).
                    ToList();
            }

        }
    }
}
