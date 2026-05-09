using FitnessCenterApp.Web.ViewModels.SpaProcedure;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface ISpaProcedureService
{
    /// <summary>
    /// Retrieves a paginated list of spa procedures with optional search, sorting order, and pagination parameters.
    /// </summary>
    Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 4);

    /// <summary>
    /// Retrieves all spa procedures based on optional search, duration filters, and sorting order.
    /// </summary>
    Task<IEnumerable<AllSpaProceduresViewModel>> GetAllSpaProceduresAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null);

    /// <summary>
    /// Retrieves a spa procedure by its identifier for editing purposes.
    /// </summary>
    Task<EditSpaProcedureViewModel?> GetSpaProceduresByIdAsync(int id);

    /// <summary>
    /// Retrieves the details of a specific spa procedure by its identifier.
    /// </summary>
    Task<SpaProcedureDetailsViewModel?> GetSpaProceduresDetailsAsync(int id);

    /// <summary>
    /// Retrieves all spa procedures booked by a specific user.
    /// </summary>
    Task<IEnumerable<AllSpaProceduresViewModel>> GetMySpaProceduresAsync(string userId);

    /// <summary>
    /// Books a spa procedure appointment for a specific user.
    /// </summary>
    Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime);

    /// <summary>
    /// Removes a user's booking for a specific spa procedure.
    /// </summary>
    Task RemoveFromMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure);

    /// <summary>
    /// Prepares the view model required for adding a new spa procedure.
    /// </summary>
    Task<AddSpaProcedureViewModel> GetSpaProcedureForAddAsync();

    /// <summary>
    /// Adds a new spa procedure to the database.
    /// </summary>
    Task AddSpaProcedureAsync(AddSpaProcedureViewModel model, string userId);

    /// <summary>
    /// Edits an existing spa procedure in the database.
    /// </summary>
    Task EditSpaProcedureAsync(EditSpaProcedureViewModel model, string userId);

    /// <summary>
    /// Retrieves a spa procedure by its identifier to confirm deletion.
    /// </summary>
    Task<DeleteSpaProcedureViewModel?> GetSpaProcedureForDeleteAsync(int id);

    /// <summary>
    /// Deletes a spa procedure from the database.
    /// </summary>
    Task DeleteSpaProcedureAsync(int id, string userId);

    /// <summary>
    /// Retrieves a list of all participants booked for a specific spa procedure.
    /// </summary>
    Task<SpaParticipantsViewModel?> GetSpaParticipantsAsync(int procedureId);

    /// <summary>
    /// Admin action to remove a specific user from a spa appointment.
    /// </summary>
    Task RemoveParticipantFromSpaAdminAsync(int procedureId, string userId);
}