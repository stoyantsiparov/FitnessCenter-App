namespace FitnessCenterApp.Web.ViewModels.FitnessClass;

public class PaginatedFitnessClassesViewModel
{
    public IEnumerable<AllFitnessClassesViewModel> FitnessClasses { get; set; } = new List<AllFitnessClassesViewModel>();

    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public int TotalPages { get; set; }

    public string? SearchQuery { get; set; }

    public bool HasPreviousPage => PageNumber > 1;

    public bool HasNextPage => PageNumber < TotalPages;
}