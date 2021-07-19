using System.ComponentModel.DataAnnotations;

namespace PizzaProject.ViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public bool IsEdited { get; set; }
    }
}
