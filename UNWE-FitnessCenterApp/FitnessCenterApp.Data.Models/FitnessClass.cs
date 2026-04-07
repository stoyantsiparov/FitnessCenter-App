using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessClass;

namespace FitnessCenterApp.Data.Models;

public class FitnessClass : BaseEntity
{
    [Key]
    [Comment("Primary key")]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    [Comment("Name of the fitness class")]
    public string Name { get; set; } = null!;

    [Comment("Image URL of the fitness class")]
    public string? ImageUrl { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    [Comment("Description of the fitness class")]
    public string Description { get; set; } = null!;

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    [Comment("Price of the fitness class")]
    public decimal Price { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = ScheduleDateTimeFormat, ApplyFormatInEditMode = true)]
    [Comment("Scheduled date and time of the fitness class")]
    public DateTime ScheduleDateTime { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    [Comment("Duration of the fitness class in minutes")]
    public int Duration { get; set; }

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    [Comment("Maximum capacity for the class")]
    public int Capacity { get; set; } = CapacityDefaultValue;

    [Comment("Foreign key to the Instructor of the fitness class")]
    [ForeignKey(nameof(Instructor))]
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; } = null!;

    [Comment("Members registered for the fitness class")]
    public virtual ICollection<FitnessClassRegistration> FitnessClassRegistrations { get; set; } = new List<FitnessClassRegistration>();
}