using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.Instructor;

namespace FitnessCenterApp.Services.Data
{
    public class InstructorService : IInstructorService
    {
        public Task<IEnumerable<AllInstructorsViewModel>> GetAllInstructorsAsync(string? searchQuery = null)
        {
            throw new NotImplementedException();
        }

        public Task<EditInstructorViewModel?> GetInstructorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InstructorDetailsViewModel?> GetInstructorDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AddInstructorViewModel> GetInstructorForAddAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddInstructorAsync(AddInstructorViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task EditInstructorAsync(EditInstructorViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteInstructorViewModel?> GetInstructorForDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInstructorAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
