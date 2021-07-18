using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaProject.Models;
using PizzaProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProject.Controllers
{
    public class ManageController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public ManageController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return View("NeedAuth");
            }

            return View();
        }
    }
}

