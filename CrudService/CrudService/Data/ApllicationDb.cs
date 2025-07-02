using CrudService.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudService // Ensure this matches the namespace
{
    public class CrudServiceContext : DbContext
    {
        public CrudServiceContext(DbContextOptions<CrudServiceContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for each table
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    id = 1,
                    name = "kiran",
                    DisplayOrder = 1
                },
                new Customer
                {
                    id = 2,
                    name = "samiksha",
                    DisplayOrder = 2
                }
                );
        }

    }
}
