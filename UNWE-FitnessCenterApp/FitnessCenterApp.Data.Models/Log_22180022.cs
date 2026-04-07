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
    //TODO: Add comment for TableName
    public string TableName { get; set; } = null!;

    [Required]
    [MaxLength(OperationTypeMaxLength)]
    //TODO: Add comment for OperationType
    public string OperationType { get; set; } = null!;

    [Required]
    //TODO: Add comment for OperationDateTime
    public DateTime OperationDateTime { get; set; } = DateTime.UtcNow;
}