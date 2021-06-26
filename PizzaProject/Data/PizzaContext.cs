using Microsoft.EntityFrameworkCore;
using PizzaProject.Models;

namespace PizzaProject.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {

        }

        public DbSet<Pizza> PizzaList { get; set; }
    }
}
