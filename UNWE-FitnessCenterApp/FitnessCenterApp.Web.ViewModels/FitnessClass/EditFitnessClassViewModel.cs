using System.ComponentModel.DataAnnotations;
using FitnessCenterApp.Web.ViewModels.Instructor;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessClass;

namespace FitnessCenterApp.Web.ViewModels.FitnessClass;

public class EditFitnessClassViewModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; } = null!;

    public string? ImageUrl { get; set; }

    [Required]
    [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
    public string Description { get; set; } = null!;

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    public decimal Price { get; set; }

    [Required]
    public string Schedule { get; set; } = null!;

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    public int Capacity { get; set; } = CapacityDefaultValue;

    [Range(1, int.MaxValue)]
    public int InstructorId { get; set; }
    public IEnumerable<AllInstructorsViewModel> Instructors { get; set; } = new List<AllInstructorsViewModel>();
}