using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "AnsarGroupTest",
                    Email = "ansargroup@test.com",
                    UserName = "ansargroup@test.com",
                    Address = new Address
                    {
                        FirstName = "Zaffar",
                        LastName = "B",
                        Street = "Al Ittihad St",
                        City = "Sharjah",
                        State = "Dubai",
                        Zipcode = "38880"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}