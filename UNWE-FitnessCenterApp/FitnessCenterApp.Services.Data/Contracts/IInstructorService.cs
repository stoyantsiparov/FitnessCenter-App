using FitnessCenterApp.Web.ViewModels.Instructor;

namespace FitnessCenterApp.Services.Data.Contracts;

public interface IInstructorService
{
    Task<IEnumerable<AllInstructorsViewModel>> GetAllInstructorsAsync(string? searchQuery = null);
    Task<EditInstructorViewModel?> GetInstructorByIdAsync(int id);
    Task<InstructorDetailsViewModel?> GetInstructorDetailsAsync(int id);
    Task<AddInstructorViewModel> GetInstructorForAddAsync();
    Task AddInstructorAsync(AddInstructorViewModel model, string userId);
    Task EditInstructorAsync(EditInstructorViewModel model, string userId);
    Task<DeleteInstructorViewModel?> GetInstructorForDeleteAsync(int id);
    Task DeleteInstructorAsync(int id, string userId);
}