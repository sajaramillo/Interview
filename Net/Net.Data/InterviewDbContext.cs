using Microsoft.EntityFrameworkCore;
using Net.Data.Entities;

namespace Net.Data
{
    public class InterviewDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public InterviewDbContext() { }

        public InterviewDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}