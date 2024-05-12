using ProjectService.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectService.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Project> Projects { get; set; }
    }
}
