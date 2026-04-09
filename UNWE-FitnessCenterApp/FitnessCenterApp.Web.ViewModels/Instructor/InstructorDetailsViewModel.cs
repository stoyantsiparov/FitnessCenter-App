namespace FitnessCenterApp.Web.ViewModels.Instructor;

public class InstructorDetailsViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Specialization { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string? ImageUrl { get; set; }
}