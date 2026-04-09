using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.FitnessClass;

namespace FitnessCenterApp.Services.Data
{
    public class FitnessClassService : IFitnessClassService
    {
        public Task<IEnumerable<AllFitnessClassesViewModel>> GetAllClassesAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedFitnessClassesViewModel> GetAllClassesPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 6)
        {
            throw new NotImplementedException();
        }

        public Task<EditFitnessClassViewModel?> GetClassByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FitnessClassDetailsViewModel?> GetClassDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllFitnessClassesViewModel>> GetMyClassesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task AddToMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<AddFitnessClassViewModel> GetClassForAddAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddClassAsync(AddFitnessClassViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task EditClassAsync(EditFitnessClassViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteFitnessClassViewModel?> GetClassForDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClassAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}