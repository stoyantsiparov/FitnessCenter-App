using FitnessCenterApp.Web.ViewModels.FitnessClass;
using static FitnessCenterApp.Common.ApplicationsConstants;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IFitnessClassService
{
    /// <summary>
    /// Retrieves all fitness classes based on optional search, duration filters, and sorting order.
    /// </summary>
    Task<IEnumerable<AllFitnessClassesViewModel>> GetAllClassesAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null);

    /// <summary>
    /// Retrieves a paginated list of fitness classes with optional search, duration filters, and sorting order.
    /// </summary>
    Task<PaginatedFitnessClassesViewModel> GetAllClassesPaginationAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null, int pageNumber = DefaultPageNumber, int pageSize = DefaultEntitiesPerPage);

    /// <summary>
    /// Retrieves a fitness class by its identifier for editing purposes.
    /// </summary>
    Task<EditFitnessClassViewModel?> GetClassByIdAsync(int id);

    /// <summary>
    /// Retrieves the details of a specific fitness class by its identifier.
    /// </summary>
    Task<FitnessClassDetailsViewModel?> GetClassDetailsAsync(int id);

    /// <summary>
    /// Retrieves all fitness classes registered to a specific user.
    /// </summary>
    Task<IEnumerable<AllFitnessClassesViewModel>> GetMyClassesAsync(string userId);

    /// <summary>
    /// Registers a user for a specific fitness class.
    /// </summary>
    Task AddToMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel);

    /// <summary>
    /// Removes a user's registration from a specific fitness class.
    /// </summary>
    Task RemoveFromMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel);

    /// <summary>
    /// Prepares the view model required for adding a new fitness class.
    /// </summary>
    Task<AddFitnessClassViewModel> GetClassForAddAsync();

    /// <summary>
    /// Adds a new fitness class to the database.
    /// </summary>
    Task AddClassAsync(AddFitnessClassViewModel model, string userId);

    /// <summary>
    /// Edits an existing fitness class in the database.
    /// </summary>
    Task EditClassAsync(EditFitnessClassViewModel model, string userId);

    /// <summary>
    /// Retrieves a fitness class by its identifier to confirm deletion.
    /// </summary>
    Task<DeleteFitnessClassViewModel?> GetClassForDeleteAsync(int id);

    /// <summary>
    /// Deletes a fitness class from the database.
    /// </summary>
    Task DeleteClassAsync(int id, string userId);

    /// <summary>
    /// Retrieves a list of all participants registered for a specific fitness class.
    /// </summary>
    Task<FitnessClassParticipantsViewModel?> GetClassParticipantsAsync(int classId);

    /// <summary>
    /// Admin action to remove a specific user from a fitness class.
    /// </summary>
    Task RemoveParticipantFromClassAdminAsync(int classId, string userId);
}