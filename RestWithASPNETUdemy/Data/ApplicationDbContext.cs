using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new SeedingService(modelBuilder).Seed();
        }


        public DbSet<Person> People { get; set; } 
    }
}
