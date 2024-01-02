using Microsoft.EntityFrameworkCore;
using Book.Models;

namespace Book.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "SciFi",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Adventure",
                    DisplayOrder = 3
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "John Wick",
                    Description = "An interesting movie",
                    ISBN = "TH1233333333",
                    Author = "Ron Parker",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                 new Product
                 {
                     Id = 2,
                     Title = "Black Adam",
                     Description = "An interesting movie",
                     ISBN = "RD128888888",
                     Author = "Ron Parker",
                     ListPrice = 25,
                     Price = 23,
                     Price50 = 22,
                     Price100 = 20
                 },
                  new Product
                  {
                      Id = 3,
                      Title = "13 Reasons ",
                      Description = "An interesting movie",
                      ISBN = "UJ2573817Y",
                      Author = "Ron Parker",
                      ListPrice = 30,
                      Price = 27,
                      Price50 = 25,
                      Price100 = 20
                  }
                );
        }
    }
}
