using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaProject.Data;
using PizzaProject.Models;
using PizzaProject.ViewModels;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly PizzaContext _context;

        public HomeController(ILogger<HomeController> logger, PizzaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                PizzaList = await _context.PizzaList.ToListAsync(),
                Cart = GetCart()
            };

            return View(viewModel);
        }

        public RedirectToActionResult AddToCart(int pizzaId, string returnUrl)
        {
            var pizza = _context.PizzaList.FirstOrDefault(t => t.Id == pizzaId);

            if (pizza is not null)
            {
                var cart = GetCart();
                cart.AddItem(pizza);

                SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int pizzaId, string returnUrl)
        {
            var pizza = _context.PizzaList.FirstOrDefault(t => t.Id == pizzaId);

            if (pizza is not null)
            {
                var cart = GetCart();
                cart.RemoveItem(pizza);

                SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public void SaveCart(Cart cart)
        {
            var cartString = JsonSerializer.Serialize(cart);

            HttpContext.Session.SetString("cart", cartString);
        }

        public Cart GetCart()
        {
            var cartString = HttpContext.Session.GetString("cart");
            Cart cart;

            if (cartString is null)
            {
                cart = new Cart();
                SaveCart(cart);
            }
            else
            {
                cart = JsonSerializer.Deserialize<Cart>(cartString);
            }

            return cart;
        }

        public IActionResult Cart()
        {
            if (GetCart().Items.Count == 0)
            {
                return View("EmptyCart");
            }

            return View(GetCart().Items);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
