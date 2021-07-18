using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaProject.Models
{
    public enum Role
    {
        Banned = -1,
        User = 0,
        Admin = 1
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Role UserRole { get; set; }
    }
}
