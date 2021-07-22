using Microsoft.AspNetCore.Identity;
using PizzaProject.Models;
using System;
using System.Threading.Tasks;

namespace PizzaProject.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await CreateRole(roleManager, "user");
            await CreateRole(roleManager, "admin");

            if (await userManager.FindByNameAsync("root") == null)
            {
                var admin = new User
                {
                    Email = "root@aws.com",
                    UserName = "root",
                    Verified = true,
                    RegistrationDate = DateTime.Now,
                    LastEditDate = DateTime.Now
                };

                IdentityResult result = await userManager.CreateAsync(admin, "root");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
                else
                {
                    throw new System.Exception("Error with seed root user");
                }
            }
        }

        private static async Task CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }
}