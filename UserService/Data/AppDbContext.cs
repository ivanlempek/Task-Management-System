using UserService.Models;
using Microsoft.EntityFrameworkCore;

namespace ImprovementService.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
