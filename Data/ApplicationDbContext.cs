using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppReports.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    public DbSet<BlazorWebAppReports.Models.Report> Report { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.TodoItem> TodoItems { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.ArchivedTodoItem> ArchivedTodoItems { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.DeletedTodoItem> DeletedTodoItems { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.ArchivedReport> ArchivedReports { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.DeletedReport> DeletedReports { get; set; } = default!;
    }
}
