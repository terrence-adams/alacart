using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALaCart.Models;
using System.ComponentModel.DataAnnotations;
using ALaCart.Service;

namespace ALaCart.Controllers
{
    public class SiteController : Controller
    {
        public List<Restaurant> Restaurants = new List<Restaurant>();

        private readonly ISiteService _siteService;
        private readonly IRestaurantService _restaurantService;
        private const string RESTAURANTS = "Restaurants";

        public SiteController(ISiteService siteService, IRestaurantService restaurantService)
        {
            _siteService = siteService;
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            if (TempData["Error"] != null)
            {
                ViewData.Add("Error", TempData["Error"]); //passing the error value to View
            }
            var restaurants = _siteService.GetAllRestaurants();
            return View(restaurants);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var restaurants = _restaurantService.GetAll();
            ViewData.Add(RESTAURANTS, restaurants);
            return View("Form");
        }


        [HttpPost]
        public IActionResult Add(Restaurant newRestaurant)
        {
            if (ModelState.IsValid)
            {
                _siteService.Create(newRestaurant);
                return RedirectToAction(nameof(Index));

            }

            return View("Form");
        }


        public IActionResult Edit(int id)
        {
            var updatedRestaurant = _siteService.GetById(id);

            return View("Form", updatedRestaurant);

        }

        [HttpPost]
        public IActionResult Edit(int id, Restaurant newRestaurant)
        {
            if (ModelState.IsValid)
            {
                _siteService.Update(newRestaurant);
                return RedirectToAction(nameof(Index));
            }

            return View("Form", newRestaurant);

        }


        public IActionResult Delete(int iD)
        {
            var deleted = _siteService.Delete(iD);
            if (!deleted)
            {
                ViewData.Add("Error", " Unable to delete restaurant at this time.");
            }
            return RedirectToAction(nameof(Index));

        }


        public IActionResult Details(int iD)
        {
            var restaurant = _siteService.GetById(iD);

            return View(restaurant);

        }
    }
}