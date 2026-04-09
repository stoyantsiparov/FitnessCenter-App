using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.FitnessEvent;

namespace FitnessCenterApp.Services.Data
{
    public class FitnessEventService : IFitnessEventService
    {
        public Task<PaginatedFitnessEventsViewModel> GetAllFitnessEventsAsync(string? searchTerm = null, int pageNumber = 1, int pageSize = 6)
        {
            throw new NotImplementedException();
        }

        public Task<EditFitnessEventViewModel?> GetFitnessEventByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FitnessEventDetailsViewModel?> GetFitnessEventDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllFitnessEventsViewModel>> GetMyFitnessEventsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task AddToMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<AddFitnessEventViewModel> GetFitnessEventForAddAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddFitnessEventAsync(AddFitnessEventViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task EditFitnessEventAsync(EditFitnessEventViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteFitnessEventViewModel?> GetFitnessEventForDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFitnessEventAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
