using System;
using GreenPath.Models;
using Microsoft.AspNetCore.Identity;

//Essa foi a primeira injeção de dados nas tabelas que criei no Db. Deixei aqui como histórico

namespace GreenPath.Data
{
	public class Seed
	{
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "reinis@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "reinis",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "Rua xxyyzz, 123",
                            City = "Belo Horizonte",
                            State = "MG"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "GreenPath@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "Rua gghhrrtt, 33214",
                            City = "São Pauloe",
                            State = "SP"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "GreenPath@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}

