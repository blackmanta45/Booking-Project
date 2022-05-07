using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Extensions
{
    public static class UserManagerExtension
    {
        public static async Task SeedUser(this UserManager<User> userManager)
        {
            var defaultUser = await userManager.FindByIdAsync("f98ebb4c-ff40-4d7b-ad63-7a81327aadb0");
            if (defaultUser is null)
            {
                var user = new User
                {
                    Id = new Guid("f98ebb4c-ff40-4d7b-ad63-7a81327aadb0"),
                    IsDeleted = false,
                    Name = "George",
                    Surname = "George",
                    UserName = "admin",
                    DateOfBirth = DateTime.Now.AddYears(-18),
                    Email = "georgegeorge@george.com",
                    Phone = "0767676767",
                    Gender = Gender.ApacheHelicopter
                };
                await userManager.CreateAsync(user, "Admin1234");

                await userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "admin"));
            }
            else
            {
                var claims = await userManager.GetClaimsAsync(defaultUser);
                if (!claims.Any())
                    await userManager.AddClaimAsync(defaultUser, new Claim(ClaimTypes.Role, "admin"));
            }
        }
    }
}