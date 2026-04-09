using System.ComponentModel.DataAnnotations;
using static FitnessCenterApp.Common.EntityValidationConstants.SpaProcedure;

namespace FitnessCenterApp.Web.ViewModels.SpaProcedure;

public class AddSpaProcedureViewModel
{
    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
    public string Description { get; set; } = null!;

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    public decimal Price { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    public string? ImageUrl { get; set; }

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    public int Capacity { get; set; } = CapacityDefaultValue;
}