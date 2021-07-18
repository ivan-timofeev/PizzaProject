using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProject.ViewModels
{
    public class CreateUserViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
