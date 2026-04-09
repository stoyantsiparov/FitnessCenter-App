namespace FitnessCenterApp.Web.ViewModels.Instructor;

public class AllInstructorsViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Specialization { get; set; } = null!;
    public string? ImageUrl { get; set; }
}