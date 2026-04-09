using System.ComponentModel.DataAnnotations;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessEvent;

namespace FitnessCenterApp.Web.ViewModels.FitnessEvent;

public class AddFitnessEventViewModel
{
    [Required]
    [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
    public string Title { get; set; } = null!;

    [Required]
    [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
    public string Description { get; set; } = null!;

    [Required]
    [StringLength(LocationMaxLength, MinimumLength = LocationMinLength)]
    public string Location { get; set; } = null!;

    public string? ImageUrl { get; set; }

    [Required]
    public string StartDate { get; set; } = null!;

    [Required]
    public string EndDate { get; set; } = null!;

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    public int Capacity { get; set; } = CapacityDefaultValue;
}