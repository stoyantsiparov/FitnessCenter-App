using FitnessCenterApp.Web.ViewModels.Admin.UserManagement;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IUserService
{
    /// <summary>
    /// Retrieves all users registered in the application.
    /// </summary>
    Task<IEnumerable<AllUsersViewModel>> GetAllUsersAsync();

    /// <summary>
    /// Checks if a user exists by their unique identifier.
    /// </summary>
    Task<bool> UserExistsByIdAsync(string userId);

    /// <summary>
    /// Assigns a specific role to a user.
    /// </summary>
    Task<bool> AssignUserToRoleAsync(string userId, string role);

    /// <summary>
    /// Removes a specific role from a user.
    /// </summary>
    Task<bool> RemoveUserRoleAsync(string userId, string role);

    /// <summary>
    /// Deletes a user account from the system entirely.
    /// </summary>
    Task<bool> DeleteUserAsync(string userId);
}