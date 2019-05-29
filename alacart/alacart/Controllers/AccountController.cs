using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALaCart.Controllers;
using ALaCart.Data;
using ALaCart.Models;
using ALaCart.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;


namespace ALaCart.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;

        public AccountController(UserManager<Customer> userManager, SignInManager<Customer> signInManager)
        {

            _userManager = userManager;
            _signInManager = signInManager;


        }


        [HttpGet]
        public IActionResult Register()
        {
            RedirectUserWhenAlreadLoggedIn();
            return View();

        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {

            if (ModelState.IsValid)
            {
                var newUser = new Customer
                {
                    PhoneNumber = vm.PhoneNumber,
                    FirstName = vm.FirstName.ToUpper(),
                    LastName = vm.LastName.ToUpper(),


                };

                var result = await _userManager.CreateAsync(newUser, vm.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");

                }

                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }

            }
            return View(vm);

        }


        [HttpGet]
        public IActionResult Login()
        {
            RedirectUserWhenAlreadLoggedIn();
            return View();

        }

        public async Task<IActionResult> LogOut()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");


        }

        private IActionResult RedirectUserWhenAlreadLoggedIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return null;

        }



    }
}
