using ImprovementService.Models;
using Microsoft.EntityFrameworkCore;

namespace ImprovementService.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Improvement> Improvements { get; set; }
    }
}
