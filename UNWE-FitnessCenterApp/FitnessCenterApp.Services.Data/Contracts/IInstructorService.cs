using FitnessCenterApp.Web.ViewModels.Instructor;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IInstructorService
{
    Task<PaginatedInstructorsViewModel> GetAllInstructorsPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 3);
    Task<IEnumerable<AllInstructorsViewModel>> GetAllInstructorsAsync();
    Task<EditInstructorViewModel?> GetInstructorByIdAsync(int id);
    Task<InstructorDetailsViewModel?> GetInstructorDetailsAsync(int id);
    Task<AddInstructorViewModel> GetInstructorForAddAsync();
    Task AddInstructorAsync(AddInstructorViewModel model, string userId);
    Task EditInstructorAsync(EditInstructorViewModel model, string userId);
    Task<DeleteInstructorViewModel?> GetInstructorForDeleteAsync(int id);
    Task DeleteInstructorAsync(int id, string userId);
}