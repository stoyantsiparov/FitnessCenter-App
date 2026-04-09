using FitnessCenterApp.Web.ViewModels.MembershipType;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IMembershipTypeService
{
    Task<IEnumerable<AllMembershipTypeViewModel>> GetAllMembershipTypesAsync();
    Task<EditMembershipTypeViewModel?> GetMembershipTypeByIdAsync(int id);
    Task<MembershipTypeDetailsViewModel?> GetMembershipTypeDetailsAsync(int id);
    Task<IEnumerable<AllMembershipTypeViewModel>> GetMyMembershipTypesAsync(string userId);
    Task AddMyMembershipAsync(string userId, EditMembershipTypeViewModel? membershipTypeViewModel);
    Task RemoveMyMembershipAsync(string userId, EditMembershipTypeViewModel? membershipTypeViewModel);
    Task<AddMembershipTypeViewModel> GetMembershipTypeForAddAsync();
    Task AddMembershipTypeAsync(AddMembershipTypeViewModel model, string userId);
    Task EditMembershipTypeAsync(EditMembershipTypeViewModel model, string userId);
    Task<DeleteMembershipTypeViewModel?> GetMembershipTypeForDeleteAsync(int id);
    Task DeleteMembershipTypeAsync(int id, string userId);
}