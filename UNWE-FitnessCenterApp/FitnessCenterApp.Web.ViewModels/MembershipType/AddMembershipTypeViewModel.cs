using System.ComponentModel.DataAnnotations;
using static FitnessCenterApp.Common.EntityValidationConstants.MembershipType;

namespace FitnessCenterApp.Web.ViewModels.MembershipType;

public class AddMembershipTypeViewModel
{
    [Required]
    [MaxLength(NameMaxLength)]
    [MinLength(NameMinLength)]
    public string Name { get; set; } = null!;

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    public decimal Price { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    [MinLength(DescriptionMinLength)]
    public string Description { get; set; } = null!;

    public string? ImageUrl { get; set; }
}