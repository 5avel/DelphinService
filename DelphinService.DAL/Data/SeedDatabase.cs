
using DelphinService.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DelphinService.DAL.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DSDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            context.Database.EnsureCreated();

            if(!context.UserClaims.Any())
            {
                AppUser user = new AppUser()
                {
                    Email = "5avel@hotmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "5avel"
                };
                userManager.CreateAsync(user, "Samsung@123");
            }
        }
    }
}
