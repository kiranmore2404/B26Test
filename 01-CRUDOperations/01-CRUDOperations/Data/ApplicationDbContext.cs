using _01_CRUDOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace _01_CRUDOperations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {
        }
        public DbSet<Categeory> Categeorys { get; set; }
    }
}
