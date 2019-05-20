using System.Collections.Generic;
using System.Text;
using ALaCart.Data;
using ALaCart.Models;
using ALaCart.Data.Interfaces;

namespace ALaCart.Service
{
    public interface IRestaurantService
    {
        Restaurant GetById(int Id);

        ICollection<Restaurant> GetAll();

    }



    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public ICollection<Restaurant> GetAll()
        {
            return _restaurantRepository.GetAll();
        }

        public Restaurant GetById(int Id)
        {
            return _restaurantRepository.GetById(Id);
        }
    }
}
