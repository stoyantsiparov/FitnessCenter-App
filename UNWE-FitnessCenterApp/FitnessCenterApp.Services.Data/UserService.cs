using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.Admin.UserManagement;

namespace FitnessCenterApp.Services.Data
{
    public class UserService : IUserService
    {
        public Task<IEnumerable<AllUsersViewModel>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AssignUserToRoleAsync(string userId, string role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserRoleAsync(string userId, string role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
