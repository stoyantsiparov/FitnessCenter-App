namespace FitnessCenterApp.Web.ViewModels.SpaProcedure;

public class AllSpaProceduresViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }    
    public string AppointmentDateTime { get; set; } = null!;
}