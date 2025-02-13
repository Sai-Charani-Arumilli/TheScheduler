using Microsoft.EntityFrameworkCore;
using SchedulerApp.Models;

namespace SchedulerApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> UsersInApplication { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users", "dbo"); // Ensures EF maps to dbo.users
        }
    }
}
