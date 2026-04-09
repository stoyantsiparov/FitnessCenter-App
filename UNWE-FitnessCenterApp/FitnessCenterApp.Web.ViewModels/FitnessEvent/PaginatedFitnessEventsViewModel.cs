namespace FitnessCenterApp.Web.ViewModels.FitnessEvent;

public class PaginatedFitnessEventsViewModel
{
    public IEnumerable<AllFitnessEventsViewModel> FitnessEvents { get; set; } = new List<AllFitnessEventsViewModel>();

    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public int TotalPages { get; set; }

    public string? SearchQuery { get; set; }

    public bool HasPreviousPage => PageNumber > 1;

    public bool HasNextPage => PageNumber < TotalPages;
}