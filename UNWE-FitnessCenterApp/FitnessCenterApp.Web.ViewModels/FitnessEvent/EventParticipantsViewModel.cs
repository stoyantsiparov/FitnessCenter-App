namespace FitnessCenterApp.Web.ViewModels.FitnessEvent;

public class ParticipantViewModel
{
    public string UserId { get; set; } = null!;
    public string Email { get; set; } = null!;
}

public class EventParticipantsViewModel
{
    public int EventId { get; set; }
    public string EventTitle { get; set; } = null!;
    public string StartDate { get; set; } = null!;
    public int Capacity { get; set; }
    public int CurrentParticipantsCount { get; set; }

    public IEnumerable<ParticipantViewModel> Participants { get; set; } = new List<ParticipantViewModel>();
}