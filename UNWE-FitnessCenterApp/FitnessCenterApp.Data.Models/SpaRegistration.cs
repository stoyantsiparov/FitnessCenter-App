using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.SpaProcedure;

namespace FitnessCenterApp.Data.Models;

public class SpaRegistration : BaseEntity
{
    [Key]
    [Comment("Primary key for the registration")]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(Member))]
    public string MemberId { get; set; } = null!;
    public IdentityUser Member { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(SpaProcedure))]
    public int SpaProcedureId { get; set; }
    public SpaProcedure SpaProcedure { get; set; } = null!;

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = AppointmentDateTimeFormat, ApplyFormatInEditMode = true)]
    [Comment("The specific date and time the user booked this procedure")]
    public DateTime AppointmentDateTime { get; set; }
}