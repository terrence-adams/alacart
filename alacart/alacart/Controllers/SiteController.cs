using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALaCart.Models;
using System.ComponentModel.DataAnnotations;

namespace ALaCart.Controllers
{
    public class SiteController : Controller
    {
        public List<Restaurant> Restaurants = new List<Restaurant>();

        public IActionResult Index()
        {
            return View(Restaurants);
        }

        public IActionResult Add()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Add(Restaurant newRestaurant)
        {
            Restaurants.Add(newRestaurant);

            return View(nameof(Index), Restaurants);

        }


        public IActionResult Edit(int id, Restaurant updatedRestaurant)
        {
            var oldRestaurant = Restaurants.Single(r => r.ID == updatedRestaurant.ID);

            oldRestaurant.Name = updatedRestaurant.Name;
            oldRestaurant.Description = updatedRestaurant.Description;

            return View(nameof(Index), Restaurants);

        }


        public IActionResult Delete(int iD)
        {
            var restaurant = Restaurants.Single(r => r.ID == iD);
            Restaurants.Remove(restaurant);
            return View(nameof(Index), Restaurants);

        }


        public IActionResult Details(int iD)
        {
            var restaurant = Restaurants.Single(r => r.ID == iD);

            return View(restaurant);

        }
    }
}