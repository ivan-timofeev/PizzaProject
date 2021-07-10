using PizzaProject.Models;
using System.Collections.Generic;

namespace PizzaProject.ViewModels
{
    public class HomeViewModel
    {
        public List<Pizza> PizzaList { get; set; }
        public Cart Cart { get; set; }
    }
}
