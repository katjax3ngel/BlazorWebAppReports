using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppReports.Models;

public class Report
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly DueDate { get; set; }

    public string? Type { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Priority { get; set; }
}