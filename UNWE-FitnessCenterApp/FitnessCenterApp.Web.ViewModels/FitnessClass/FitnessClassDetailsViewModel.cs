using FitnessCenterApp.Web.ViewModels.Instructor;

namespace FitnessCenterApp.Web.ViewModels.FitnessClass;

public class FitnessClassDetailsViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public string Schedule { get; set; } = null!;
    public int Duration { get; set; }
    public int Capacity { get; set; }

    public InstructorInfoViewModel Instructor { get; set; } = null!;
}