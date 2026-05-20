namespace BlazorWebAppReports.Models
{
    public class ArchivedTodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime ArchivedDate { get; set; }
    }
}