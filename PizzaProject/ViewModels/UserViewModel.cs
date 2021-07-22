using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProject.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            RegistrationDate = user.RegistrationDate;
            LastEditDate = user.LastEditDate;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Verified = user.Verified;

            BaseObject = user;
        }

        public User BaseObject { get; set; }

        public DateTime RegistrationDate { get; set; }
        public DateTime LastEditDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Verified { get; set; }
        public bool IsAdmin { get; set; }
    }
}
