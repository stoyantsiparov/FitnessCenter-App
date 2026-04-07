using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.SpaProcedure;

namespace FitnessCenterApp.Data.Models;

public class SpaProcedure : BaseEntity
{
    [Key]
    [Comment("Primary key")]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    [Comment("Spa type")]
    public string Name { get; set; } = null!;

    [Comment("Image URL of the spa procedure")]
    public string? ImageUrl { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    [Comment("Description of the spa procedure")]
    public string Description { get; set; } = null!;

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    [Comment("Duration of the spa procedure in minutes")]
    public int Duration { get; set; }

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    [Comment("Price of the spa procedure")]
    public decimal Price { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = AppointmentDateTimeFormat, ApplyFormatInEditMode = true)]
    [Comment("Appointment date and time for the spa service")]
    public DateTime AppointmentDateTime { get; set; }

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    [Comment("Maximum capacity for the procedure")]
    public int Capacity { get; set; } = CapacityDefaultValue;

    [Comment("Registrations for this spa procedure")]
    public virtual ICollection<SpaRegistration> SpaRegistrations { get; set; } = new List<SpaRegistration>();
}