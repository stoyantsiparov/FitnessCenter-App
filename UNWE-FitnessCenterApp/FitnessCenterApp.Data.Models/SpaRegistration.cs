using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Models;

[PrimaryKey(nameof(MemberId), nameof(SpaProcedureId))]
public class SpaRegistration : BaseEntity
{
    [ForeignKey(nameof(Member))]
    public string MemberId { get; set; } = null!;
    public IdentityUser Member { get; set; } = null!;

    [ForeignKey(nameof(SpaProcedure))]
    public int SpaProcedureId { get; set; }
    public SpaProcedure SpaProcedure { get; set; } = null!;
}