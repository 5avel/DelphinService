using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelphinService.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
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
