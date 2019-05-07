using System;
using System.Collections.Generic;
using System.Text;
using ALaCart.Data;
using ALaCart.Models;
using ALaCart.Data.Interfaces;

namespace ALaCart.Service
{
    public interface ISiteService
    {

        //CRUD
        Restaurant Create(Restaurant newRestaurant);

        bool Delete(int iD);

        Restaurant Update(Restaurant oldRestaurant);

        Restaurant GetById(int id);

        ICollection<Restaurant> GetAllRestaurants();


    }

    public class SiteService : ISiteService
    {
        private readonly ISiteRepository _siteRepository;

        public SiteService(ISiteRepository siteRepository)
        {

            _siteRepository = siteRepository; //initialize the internal variable
        }

        public Restaurant Create(Restaurant newRestaurant)
        {
            return _siteRepository.Create(newRestaurant);
        }

        public bool Delete(int iD)
        {
            return _siteRepository.Delete(iD);
        }

        public Restaurant GetById(int id)
        {
            return _siteRepository.GetById(id);
        }

        public Restaurant Update(Restaurant oldRestaurant)
        {
            return _siteRepository.Update(oldRestaurant);
        }


        public ICollection<Restaurant> GetAllRestaurants()
        {

            return _siteRepository.GetAllRestaurants();
        }
    }
}
