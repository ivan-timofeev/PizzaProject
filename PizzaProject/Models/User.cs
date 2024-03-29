﻿using Microsoft.AspNetCore.Identity;
using System;

namespace PizzaProject.Models
{
    public class User : IdentityUser
    {
        public DateTime RegistrationDate { get; set; }
        public DateTime LastEditDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Verified { get; set; }
    }
}
