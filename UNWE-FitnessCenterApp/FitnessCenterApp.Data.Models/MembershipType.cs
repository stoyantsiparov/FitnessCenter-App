using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.MembershipType;

namespace FitnessCenterApp.Data.Models;

public class MembershipType : BaseEntity
{
    [Key]
    [Comment("Primary key")]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    [Comment("Name of the membership plan")]
    public string Name { get; set; } = null!;

    [Required]
    [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
    [Comment("Price of the membership")]
    public decimal Price { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    [Comment("Duration in days")]
    public int Duration { get; set; }

    [Comment("Image URL of the membership plan")]
    public string? ImageUrl { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    [Comment("Description of the plan benefits")]
    public string Description { get; set; } = null!;

    [Comment("Members registered for this membership type")]
    public virtual ICollection<MembershipRegistration> MembershipRegistrations { get; set; } = new List<MembershipRegistration>();
}