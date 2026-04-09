using FitnessCenterApp.Web.ViewModels.FitnessEvent;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IFitnessEventService
{
    Task<PaginatedFitnessEventsViewModel> GetAllFitnessEventsAsync(string? searchTerm = null, int pageNumber = 1, int pageSize = 6);
    Task<EditFitnessEventViewModel?> GetFitnessEventByIdAsync(int id);
    Task<FitnessEventDetailsViewModel?> GetFitnessEventDetailsAsync(int id);
    Task<IEnumerable<AllFitnessEventsViewModel>> GetMyFitnessEventsAsync(string userId);
    Task AddToMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel);
    Task RemoveFromMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel);
    Task<AddFitnessEventViewModel> GetFitnessEventForAddAsync();
    Task AddFitnessEventAsync(AddFitnessEventViewModel model, string userId);
    Task EditFitnessEventAsync(EditFitnessEventViewModel model, string userId);
    Task<DeleteFitnessEventViewModel?> GetFitnessEventForDeleteAsync(int id);
    Task DeleteFitnessEventAsync(int id, string userId);
}