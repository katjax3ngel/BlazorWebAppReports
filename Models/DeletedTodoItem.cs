namespace BlazorWebAppReports.Models
{
    public class DeletedTodoItem
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool IsDone { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}