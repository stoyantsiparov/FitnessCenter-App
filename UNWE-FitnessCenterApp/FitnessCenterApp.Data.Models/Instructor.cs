using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.Instructor;

namespace FitnessCenterApp.Data.Models;

public class Instructor : BaseEntity
{
    [Key]
    [Comment("Primary key")]
    public int Id { get; set; }

    [Required]
    [MaxLength(FirstNameMaxLength)]
    [Comment("Instructor's first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(LastNameMaxLength)]
    [Comment("Instructor's last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [MaxLength(BioMaxLength)]
    [Comment("Instructor's biography")]
    public string Bio { get; set; } = null!;

    [Required]
    [MaxLength(SpecializationMaxLength)]
    [Comment("Instructor's primary specialization")]
    public string Specialization { get; set; } = null!;

    [Comment("Image URL of the instructor")]
    public string? ImageUrl { get; set; }

    [Comment("Classes led by the instructor")]
    public virtual ICollection<FitnessClass> FitnessClasses { get; set; } = new List<FitnessClass>();
}