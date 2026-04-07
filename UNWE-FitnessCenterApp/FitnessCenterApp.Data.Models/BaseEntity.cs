using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data.Models;

public abstract class BaseEntity
{
    [Required]
    [Comment("Date and time of the last modification")]
    public DateTime ModifiedOn_22180022 { get; set; } = DateTime.UtcNow;
}