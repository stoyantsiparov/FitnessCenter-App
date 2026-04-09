using System.ComponentModel.DataAnnotations;
using static FitnessCenterApp.Common.EntityValidationConstants.Instructor;

namespace FitnessCenterApp.Web.ViewModels.Instructor;

public class AddInstructorViewModel
{
    [Required]
    [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
    public string LastName { get; set; } = null!;

    [Required]
    [StringLength(BioMaxLength, MinimumLength = BioMinLength)]
    public string Bio { get; set; } = null!;

    [Required]
    [StringLength(SpecializationMaxLength, MinimumLength = SpecializationMinLength)]
    public string Specialization { get; set; } = null!;

    public string? ImageUrl { get; set; }
}