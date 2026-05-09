using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.Admin.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ErrorMessages.General;

namespace FitnessCenterApp.Services.Data;

public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UserService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllUsersViewModel>> GetAllUsersAsync()
    {
        var users = await _userManager.Users.ToListAsync();
        var allUsersViewModel = new List<AllUsersViewModel>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);

            allUsersViewModel.Add(new AllUsersViewModel
            {
                Id = user.Id,
                Email = user.Email ?? string.Empty,
                Roles = roles
            });
        }

        return allUsersViewModel;
    }

    /// <inheritdoc />
    public async Task<bool> UserExistsByIdAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId)) return false;

        var user = await _userManager.FindByIdAsync(userId);

        return user != null;
    }

    /// <inheritdoc />
    public async Task<bool> AssignUserToRoleAsync(string userId, string role)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return false;
        }

        var roleExists = await _roleManager.RoleExistsAsync(role);
        if (!roleExists)
        {
            return false;
        }

        var alreadyInRole = await _userManager.IsInRoleAsync(user, role);
        if (alreadyInRole)
        {
            return false;
        }

        var result = await _userManager.AddToRoleAsync(user, role);

        return result.Succeeded;
    }

    /// <inheritdoc />
    public async Task<bool> RemoveUserRoleAsync(string userId, string role)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return false;
        }

        var roleExists = await _roleManager.RoleExistsAsync(role);
        if (!roleExists)
        {
            return false;
        }

        var inRole = await _userManager.IsInRoleAsync(user, role);
        if (!inRole)
        {
            return false;
        }

        var result = await _userManager.RemoveFromRoleAsync(user, role);

        return result.Succeeded;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteUserAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return false;
        }

        var result = await _userManager.DeleteAsync(user);

        return result.Succeeded;
    }
}