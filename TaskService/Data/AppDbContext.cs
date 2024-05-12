using TaskService.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskService.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
