using CQRS.Features.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS.Features.Configurations
{
    public class BrandTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands")
                    .HasKey(x => x.Id);
            builder.HasData(new Brand[]
            {
                new Brand() { Id=1, Name="Apple"},
                new Brand() { Id=2, Name="Google"},
                new Brand() { Id=3, Name="Samsung"},
            });
        }
    }
}