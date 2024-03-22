

using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                    new Product() { ProductId = 2, ProductName = "Klavye", Price = 10_000 },
                    new Product() { ProductId = 3, ProductName = "Monitor", Price = 35_000 },
                    new Product() { ProductId = 4, ProductName = "Deck", Price = 20_000 },
                    new Product() { ProductId = 5, ProductName = "Mouse", Price = 1_000 }

                );

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { CategoryId=1, CategoryName = "Book"},
                    new Category() { CategoryId=2, CategoryName = "Electronics"}
                 );
        }
    }
}
