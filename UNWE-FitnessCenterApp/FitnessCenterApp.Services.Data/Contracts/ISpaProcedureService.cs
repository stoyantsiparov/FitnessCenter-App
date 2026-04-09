using FitnessCenterApp.Web.ViewModels.SpaProcedure;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface ISpaProcedureService
{
    Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 4);
    Task<IEnumerable<AllSpaProceduresViewModel>> GetAllSpaProceduresAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null);
    Task<EditSpaProcedureViewModel?> GetSpaProceduresByIdAsync(int id);
    Task<SpaProcedureDetailsViewModel?> GetSpaProceduresDetailsAsync(int id);
    Task<IEnumerable<AllSpaProceduresViewModel>> GetMySpaProceduresAsync(string userId);
    Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime);
    Task RemoveFromMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure);
    Task<AddSpaProcedureViewModel> GetSpaProcedureForAddAsync();
    Task AddSpaProcedureAsync(AddSpaProcedureViewModel model, string userId);
    Task EditSpaProcedureAsync(EditSpaProcedureViewModel model, string userId);
    Task<DeleteSpaProcedureViewModel?> GetSpaProcedureForDeleteAsync(int id);
    Task DeleteSpaProcedureAsync(int id, string userId);
}