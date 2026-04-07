using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessEvent;

namespace FitnessCenterApp.Data.Models;

public class FitnessEvent : BaseEntity
{
    [Key]
    [Comment("Primary key")]
    public int Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    [Comment("Title of the fitness event")]
    public string Title { get; set; } = null!;

    [Comment("Image URL of the fitness event")]
    public string? ImageUrl { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    [Comment("Description of the fitness event")]
    public string Description { get; set; } = null!;

    [Required]
    [MaxLength(LocationMaxLength)]
    [Comment("Location of the fitness event")]
    public string Location { get; set; } = null!;

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = DateTimeFormat, ApplyFormatInEditMode = true)]
    [Comment("Start date of the fitness event")]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = DateTimeFormat, ApplyFormatInEditMode = true)]
    [Comment("End date of the fitness event")]
    public DateTime EndDate { get; set; }

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    [Comment("Maximum capacity for the event")]
    public int Capacity { get; set; } = CapacityDefaultValue;

    [Comment("Members registered for the fitness event")]
    public virtual ICollection<FitnessEventRegistration> FitnessEventRegistrations { get; set; } = new List<FitnessEventRegistration>();
}