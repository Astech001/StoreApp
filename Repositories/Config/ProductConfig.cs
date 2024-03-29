
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                    new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/1.jpeg", ProductName = "Computer", Price = 17_000 },
                    new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/2.jpeg", ProductName = "Klavye", Price = 10_000 },
                    new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.jpeg", ProductName = "Monitor", Price = 35_000 },
                    new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/4.jpeg", ProductName = "Deck", Price = 20_000 },
                    new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.jpeg", ProductName = "Mouse", Price = 1_000 },
                    new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/6.jpeg", ProductName = "History", Price = 25 },
                    new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/7.jpeg", ProductName = "Hamlet", Price = 45 }
                );
        }
    }
}
