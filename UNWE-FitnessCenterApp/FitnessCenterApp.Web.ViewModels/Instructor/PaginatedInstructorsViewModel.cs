namespace FitnessCenterApp.Web.ViewModels.Instructor;

public class PaginatedInstructorsViewModel
{
    public IEnumerable<AllInstructorsViewModel> Instructors { get; set; } = new List<AllInstructorsViewModel>();
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public string? SearchQuery { get; set; }
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
}