using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using static FitnessCenterApp.Common.ApplicationsConstants;

namespace FitnessCenterApp.Data.Seeds;

public static class RolesAndUsersSeeder
{
    public static async Task SeedAsync(IServiceProvider serviceProvider, IConfiguration configuration)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

        // 1. Create roles using constants
        string[] roles = { AdminRole, MemberRole, UserRole };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        // 2. Create users and assign roles using constants
        await SeedUserAsync(userManager, configuration, "AdminSettings", AdminRole);
        await SeedUserAsync(userManager, configuration, "MemberSettings", MemberRole);
        await SeedUserAsync(userManager, configuration, "UserSettings", UserRole);
    }

    private static async Task SeedUserAsync(UserManager<IdentityUser> userManager, IConfiguration configuration, string configSection, string roleName)
    {
        string? email = configuration[$"{configSection}:Username"];
        string? password = configuration[$"{configSection}:Password"];

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            return;
        }

        var existingUser = await userManager.FindByEmailAsync(email);

        if (existingUser == null)
        {
            var user = new IdentityUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, roleName);
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"Failed to create {roleName} user: {errors}");
            }
        }
    }
}