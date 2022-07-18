using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; } 
    }
}
