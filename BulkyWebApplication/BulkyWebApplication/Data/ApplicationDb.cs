using BulkyWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebApplication.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Category>().HasData(
                  new Category { Catagory21Id = 1, Name = "Web Development", DisplayOrder = 1 },
                   new Category { Catagory21Id = 2, Name = "Action", DisplayOrder = 2 },
                  new Category { Catagory21Id = 3, Name = "history", DisplayOrder = 3 });




        }
    }

}
