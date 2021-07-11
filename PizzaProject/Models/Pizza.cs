using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaProject.Models
{
    public class Pizza
    {
        public int      Id              { get; set; }
        public string   Name            { get; set; }
        public string   Description     { get; set; }

        [Display(Name = "Picture URL")]
        public string   PictureUrl      { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal  Price           { get; set; }
    }
}
