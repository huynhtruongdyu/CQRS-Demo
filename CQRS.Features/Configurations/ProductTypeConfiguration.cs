using CQRS.Features.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS.FeaturesData.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products")
                        .HasKey(x => x.Id);
            builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.BrandId);
            builder.HasData(new Product[]
            {
                new Product() { Id=1, Name="Iphone 13", BrandId=1},
                new Product() { Id=2, Name="Iphone 13 Pro Max", BrandId=1},

                new Product() { Id=3, Name="Google Pixel 4", BrandId=2},
                new Product() { Id=4, Name="Google Pixel 5", BrandId = 2 },
                new Product() { Id=5, Name="Google Pixel 6", BrandId=2},

                new Product() { Id=6, Name="Samsung S21 Ultra", BrandId=3},
                new Product() { Id=7, Name="Samsung Note 10", BrandId=3},
            });
        }
    }
}