using System.ComponentModel.DataAnnotations;

namespace PizzaProject.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить этот компьютер")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
