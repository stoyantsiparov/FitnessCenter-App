using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Models;

[PrimaryKey(nameof(MemberId), nameof(FitnessClassId))]
public class FitnessClassRegistration
{
    [ForeignKey(nameof(Member))]
    public string MemberId { get; set; } = null!;
    public IdentityUser Member { get; set; } = null!;

    [ForeignKey(nameof(FitnessClass))]
    public int FitnessClassId { get; set; }
    public FitnessClass FitnessClass { get; set; } = null!;
}