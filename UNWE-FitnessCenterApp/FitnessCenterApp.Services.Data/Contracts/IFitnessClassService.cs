using FitnessCenterApp.Web.ViewModels.FitnessClass;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IFitnessClassService
{
    Task<IEnumerable<AllFitnessClassesViewModel>> GetAllClassesAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null);
    Task<PaginatedFitnessClassesViewModel> GetAllClassesPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 6);
    Task<EditFitnessClassViewModel?> GetClassByIdAsync(int id);
    Task<FitnessClassDetailsViewModel?> GetClassDetailsAsync(int id);
    Task<IEnumerable<AllFitnessClassesViewModel>> GetMyClassesAsync(string userId);
    Task AddToMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel);
    Task RemoveFromMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel);
    Task<AddFitnessClassViewModel> GetClassForAddAsync();
    Task AddClassAsync(AddFitnessClassViewModel model, string userId);
    Task EditClassAsync(EditFitnessClassViewModel model, string userId);
    Task<DeleteFitnessClassViewModel?> GetClassForDeleteAsync(int id);
    Task DeleteClassAsync(int id, string userId);
}