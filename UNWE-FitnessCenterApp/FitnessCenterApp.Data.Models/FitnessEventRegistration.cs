using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Models;

[PrimaryKey(nameof(MemberId), nameof(EventId))]
public class FitnessEventRegistration : BaseEntity
{
    [ForeignKey(nameof(Member))]
    public string MemberId { get; set; } = null!;
    public IdentityUser Member { get; set; } = null!;

    [ForeignKey(nameof(FitnessEvent))]
    public int EventId { get; set; }
    public FitnessEvent FitnessEvent { get; set; } = null!;
}
