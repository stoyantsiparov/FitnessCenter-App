using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.SpaProcedure;

namespace FitnessCenterApp.Services.Data
{
    public class SpaProcedureService : ISpaProcedureService
    {
        public Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 4)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllSpaProceduresViewModel>> GetAllSpaProceduresAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null)
        {
            throw new NotImplementedException();
        }

        public Task<EditSpaProcedureViewModel?> GetSpaProceduresByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SpaProcedureDetailsViewModel?> GetSpaProceduresDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllSpaProceduresViewModel>> GetMySpaProceduresAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure)
        {
            throw new NotImplementedException();
        }

        public Task<AddSpaProcedureViewModel> GetSpaProcedureForAddAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddSpaProcedureAsync(AddSpaProcedureViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task EditSpaProcedureAsync(EditSpaProcedureViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSpaProcedureViewModel?> GetSpaProcedureForDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSpaProcedureAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
