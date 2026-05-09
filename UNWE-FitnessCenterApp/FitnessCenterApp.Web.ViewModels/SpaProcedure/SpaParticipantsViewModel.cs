namespace FitnessCenterApp.Web.ViewModels.SpaProcedure;

public class SpaParticipantViewModel
{
    public string UserId { get; set; } = null!;
    public string Email { get; set; } = null!;
}

public class SpaParticipantsViewModel
{
    public int ProcedureId { get; set; }
    public string ProcedureName { get; set; } = null!;
    public string AppointmentDateTime { get; set; } = null!;
    public int Capacity { get; set; }
    public int CurrentParticipantsCount { get; set; }

    public IEnumerable<SpaParticipantViewModel> Participants { get; set; } = new List<SpaParticipantViewModel>();
}