namespace FitnessCenterApp.Web.ViewModels.SpaProcedure;

public class SpaProcedureDetailsViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int Duration { get; set; }
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }
}