using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppReports.Models;

public class DeletedReport
{
    public int Id { get; set; }

    public int OriginalReportId { get; set; }

    public string? Title { get; set; }

    public DateTime DueDate { get; set; }

    public string? Type { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Priority { get; set; }

    public string? AssignedTo { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public DateTime DeletedDate { get; set; }
}