using FitnessCenterApp.Web.ViewModels.MembershipType;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IMembershipTypeService
{
    /// <summary>
    /// Retrieves all membership types.
    /// </summary>
    Task<IEnumerable<AllMembershipTypeViewModel>> GetAllMembershipTypesAsync();

    /// <summary>
    /// Retrieves a membership type by its identifier for editing purposes.
    /// </summary>
    Task<EditMembershipTypeViewModel?> GetMembershipTypeByIdAsync(int id);

    /// <summary>
    /// Retrieves the details of a specific membership type by its identifier.
    /// </summary>
    Task<MembershipTypeDetailsViewModel?> GetMembershipTypeDetailsAsync(int id);

    /// <summary>
    /// Retrieves the membership type assigned to a specific user.
    /// </summary>
    Task<IEnumerable<AllMembershipTypeViewModel>> GetMyMembershipTypesAsync(string userId);

    /// <summary>
    /// Assigns a membership type to a specific user.
    /// </summary>
    Task AddMyMembershipAsync(string userId, EditMembershipTypeViewModel? membershipTypeViewModel);

    /// <summary>
    /// Removes a membership type from a specific user.
    /// </summary>
    Task RemoveMyMembershipAsync(string userId, EditMembershipTypeViewModel? membershipTypeViewModel);

    /// <summary>
    /// Prepares the view model required for adding a new membership type.
    /// </summary>
    Task<AddMembershipTypeViewModel> GetMembershipTypeForAddAsync();

    /// <summary>
    /// Adds a new membership type to the database.
    /// </summary>
    Task AddMembershipTypeAsync(AddMembershipTypeViewModel model, string userId);

    /// <summary>
    /// Edits an existing membership type in the database.
    /// </summary>
    Task EditMembershipTypeAsync(EditMembershipTypeViewModel model, string userId);

    /// <summary>
    /// Retrieves a membership type by its identifier to confirm deletion.
    /// </summary>
    Task<DeleteMembershipTypeViewModel?> GetMembershipTypeForDeleteAsync(int id);

    /// <summary>
    /// Deletes a membership type from the database.
    /// </summary>
    Task DeleteMembershipTypeAsync(int id, string userId);
}