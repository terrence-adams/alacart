using System.Collections.Generic;
using System.Text;
using ALaCart.Data;
using ALaCart.Models;
using ALaCart.Data.Interfaces;

namespace ALaCart.Service
{
    public interface IRestaurantService
    {
        Restaurant GetById();

        ICollection<Restaurant> GetAll();

    }



    public class RestaurantService : IRestaurantService
    {
        public ICollection<Restaurant> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Restaurant GetById()
        {
            throw new System.NotImplementedException();
        }
    }
}
