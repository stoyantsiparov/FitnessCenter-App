namespace FitnessCenterApp.Web.ViewModels.FitnessClass;

public class FitnessClassParticipantViewModel
{
    public string UserId { get; set; } = null!;
    public string Email { get; set; } = null!;
}

public class FitnessClassParticipantsViewModel
{
    public int ClassId { get; set; }
    public string ClassName { get; set; } = null!;
    public string Schedule { get; set; } = null!;
    public int Capacity { get; set; }
    public int CurrentParticipantsCount { get; set; }

    public IEnumerable<FitnessClassParticipantViewModel> Participants { get; set; } = new List<FitnessClassParticipantViewModel>();
}