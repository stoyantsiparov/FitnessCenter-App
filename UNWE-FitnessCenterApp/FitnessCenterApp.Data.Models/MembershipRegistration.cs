using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Models;

[PrimaryKey(nameof(MemberId), nameof(MembershipTypeId))]
public class MembershipRegistration : BaseEntity
{
    [ForeignKey(nameof(Member))]
    public string MemberId { get; set; } = null!;
    public IdentityUser Member { get; set; } = null!;

    [ForeignKey(nameof(MembershipType))]
    public int MembershipTypeId { get; set; }
    public MembershipType MembershipType { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }
}