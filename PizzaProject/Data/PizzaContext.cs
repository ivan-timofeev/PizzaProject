using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaProject.Models;

namespace PizzaProject.Data
{
    public class PizzaContext : IdentityDbContext<User>
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza[]
                {
                    new Pizza { Id = 1, Name = "Пицца Барбекю", PictureUrl = "/img/1.jpeg", Price = 750, Description = "Большая пицца Барбекю, 35см, 630г." },
                    new Pizza { Id = 2, Name = "Пицца Сырная", PictureUrl = "/img/2.jpeg", Price = 410, Description = "Большая пицца Сырная, 35см, 540г."},
                    new Pizza { Id = 3,Name = "Пицца Пеперони", PictureUrl = "/img/3.jpeg", Price = 500, Description = "Большая пицца Пеперони, 35см, 570г."},
                    new Pizza { Id = 4,Name = "Пицца Ветчина и сыр", PictureUrl = "/img/4.jpeg", Price = 500, Description = "Большая пицца Ветчина и сыр, 35см, 570г."}
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pizza> PizzaList { get; set; }
        public DbSet<User> UserList { get; set; }
    }
}
