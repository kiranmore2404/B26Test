using Microsoft.EntityFrameworkCore;
// This should point to the namespace where the Detail class is located
using Bulky.Models;
using bulky.DataAccess;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bulky.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define the DbSet for the Detail entity
        public DbSet<Details> Details { get; set; }  // Make sure 'Detail' is referenced correctly
    }
}

    

