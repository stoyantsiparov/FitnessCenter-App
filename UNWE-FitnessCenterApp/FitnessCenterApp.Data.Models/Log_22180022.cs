using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.EntityValidationConstants.Log_22180022;

namespace FitnessCenterApp.Data.Models;

[Comment("Log table for tracking database changes")]
[Table("log_22180022")]
public class Log_22180022
{
    [Key]
    public int Id { get; set; }

    [Required] 
    [MaxLength(TableNameMaxLength)]
    [Comment("Name of the table where the operation occurred")]
    public string TableName { get; set; } = null!;

    [Required]
    [MaxLength(OperationTypeMaxLength)]
    [Comment("Type of operation performed (e.g., INSERT, UPDATE, DELETE)")]
    public string OperationType { get; set; } = null!;

    [Required]
    [Comment("Date and time when the operation was performed")]
    public DateTime OperationDateTime { get; set; } = DateTime.UtcNow;
}