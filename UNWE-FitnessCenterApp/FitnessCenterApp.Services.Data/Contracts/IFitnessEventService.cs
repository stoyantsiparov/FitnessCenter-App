using FitnessCenterApp.Web.ViewModels.FitnessEvent;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IFitnessEventService
{
    /// <summary>
    /// Retrieves a paginated list of fitness events with optional search term and sorting order.
    /// </summary>
    Task<PaginatedFitnessEventsViewModel> GetAllFitnessEventsAsync(string? searchTerm = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 6);

    /// <summary>
    /// Retrieves a fitness event by its identifier for editing purposes.
    /// </summary>
    Task<EditFitnessEventViewModel?> GetFitnessEventByIdAsync(int id);

    /// <summary>
    /// Retrieves the details of a specific fitness event by its identifier.
    /// </summary>
    Task<FitnessEventDetailsViewModel?> GetFitnessEventDetailsAsync(int id);

    /// <summary>
    /// Retrieves all fitness events registered to a specific user.
    /// </summary>
    Task<IEnumerable<AllFitnessEventsViewModel>> GetMyFitnessEventsAsync(string userId);

    /// <summary>
    /// Registers a user for a specific fitness event.
    /// </summary>
    Task AddToMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel);

    /// <summary>
    /// Removes a user's registration from a specific fitness event.
    /// </summary>
    Task RemoveFromMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel);

    /// <summary>
    /// Prepares the view model required for adding a new fitness event.
    /// </summary>
    Task<AddFitnessEventViewModel> GetFitnessEventForAddAsync();

    /// <summary>
    /// Adds a new fitness event to the database.
    /// </summary>
    Task AddFitnessEventAsync(AddFitnessEventViewModel model, string userId);

    /// <summary>
    /// Edits an existing fitness event in the database.
    /// </summary>
    Task EditFitnessEventAsync(EditFitnessEventViewModel model, string userId);

    /// <summary>
    /// Retrieves a fitness event by its identifier to confirm deletion.
    /// </summary>
    Task<DeleteFitnessEventViewModel?> GetFitnessEventForDeleteAsync(int id);

    /// <summary>
    /// Deletes a fitness event from the database.
    /// </summary>
    Task DeleteFitnessEventAsync(int id, string userId);

    /// <summary>
    /// Retrieves a list of all participants registered for a specific event.
    /// </summary>
    Task<EventParticipantsViewModel?> GetEventParticipantsAsync(int eventId);

    /// <summary>
    /// Admin action to remove a specific user from an event.
    /// </summary>
    Task RemoveParticipantFromEventAdminAsync(int eventId, string userId);
}