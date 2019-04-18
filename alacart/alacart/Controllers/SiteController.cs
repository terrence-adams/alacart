using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALaCart.Models;


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
    }
}