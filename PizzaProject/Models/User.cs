using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
