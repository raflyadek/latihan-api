using Microsoft.EntityFrameworkCore;
using Models;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) {}
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasKey(u => u.PID);
            modelBuilder.Entity<Doctor>().HasKey(d => d.UNITID);
        }
    }

}