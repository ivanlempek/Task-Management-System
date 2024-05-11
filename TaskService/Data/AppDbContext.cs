using TaskService.Models;
using Microsoft.EntityFrameworkCore;

namespace ImprovementService.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TaskService.Models.Task> Tasks { get; set; }
    }
}
