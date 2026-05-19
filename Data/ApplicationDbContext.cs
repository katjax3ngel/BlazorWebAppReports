using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppReports.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    public DbSet<BlazorWebAppReports.Models.Report> Report { get; set; } = default!;
    public DbSet<BlazorWebAppReports.Models.TodoItem> TodoItems { get; set; } = default!;
    }
}
