namespace BlazorWebAppReports.Models
{
    public class DeletedReport
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime DueDate { get; set; }

        public string? Type { get; set; }

        public decimal Priority { get; set; }

        public string? Description { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}