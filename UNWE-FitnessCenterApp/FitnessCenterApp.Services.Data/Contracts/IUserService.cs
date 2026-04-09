using FitnessCenterApp.Web.ViewModels.Admin.UserManagement;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IUserService
{
    Task<IEnumerable<AllUsersViewModel>> GetAllUsersAsync();

    Task<bool> UserExistsByIdAsync(string userId);
    Task<bool> AssignUserToRoleAsync(string userId, string role);
    Task<bool> RemoveUserRoleAsync(string userId, string role);
    Task<bool> DeleteUserAsync(string userId);
}