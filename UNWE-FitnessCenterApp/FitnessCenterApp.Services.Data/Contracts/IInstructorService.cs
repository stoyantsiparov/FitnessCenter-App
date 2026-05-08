using FitnessCenterApp.Web.ViewModels.Instructor;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IInstructorService
{
    /// <summary>
    /// Retrieves a paginated list of instructors with optional search term and sorting order.
    /// </summary>
    Task<PaginatedInstructorsViewModel> GetAllInstructorsPaginationAsync(string? searchQuery = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 3);

    /// <summary>
    /// Retrieves all instructors without pagination.
    /// </summary>
    Task<IEnumerable<AllInstructorsViewModel>> GetAllInstructorsAsync();

    /// <summary>
    /// Retrieves an instructor by their identifier for editing purposes.
    /// </summary>
    Task<EditInstructorViewModel?> GetInstructorByIdAsync(int id);

    /// <summary>
    /// Retrieves the details of a specific instructor by their identifier.
    /// </summary>
    Task<InstructorDetailsViewModel?> GetInstructorDetailsAsync(int id);

    /// <summary>
    /// Prepares the view model required for adding a new instructor.
    /// </summary>
    Task<AddInstructorViewModel> GetInstructorForAddAsync();

    /// <summary>
    /// Adds a new instructor to the database.
    /// </summary>
    Task AddInstructorAsync(AddInstructorViewModel model, string userId);

    /// <summary>
    /// Edits an existing instructor in the database.
    /// </summary>
    Task EditInstructorAsync(EditInstructorViewModel model, string userId);

    /// <summary>
    /// Retrieves an instructor by their identifier to confirm deletion.
    /// </summary>
    Task<DeleteInstructorViewModel?> GetInstructorForDeleteAsync(int id);

    /// <summary>
    /// Deletes an instructor from the database.
    /// </summary>
    Task DeleteInstructorAsync(int id, string userId);
}