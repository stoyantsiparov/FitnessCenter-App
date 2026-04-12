namespace FitnessCenterApp.Web.ViewModels.FitnessClass;

public class AllFitnessClassesViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Schedule { get; set; } = null!;
    public int Duration { get; set; }
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }
}