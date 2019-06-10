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
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager; //need to verify if passing in parent class allows usage of child class


        }


        [HttpGet]
        public IActionResult Register()
        {
            RedirectUserWhenAlreadLoggedIn();
            var roles = _roleManager.Roles.ToList();

            var vm = new RegisterViewModel
            {
                Roles = roles
            };

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
                    result = await _userManager.AddToRoleAsync(newUser, vm.Role);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, false);

                        if (vm.Role == "AdminController")
                        {
                            return RedirectToAction("Index", "Admin");
                        }

                        else if (vm.Role == "Vendor")
                        {
                            return RedirectToAction("Index", "Vendor");

                        }

                        return RedirectToAction("Index", "Account");
                    }

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


        [HttpPost]
        public async Task<IActionResult> Login(LogInViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.PhoneNumber, vm.Password, vm.RememberMe, false);
                var user = User;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect.");
                }

            }

            return View(vm);



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
