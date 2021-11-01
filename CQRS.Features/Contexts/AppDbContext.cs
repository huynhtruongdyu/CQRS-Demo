using CQRS.Features.Configurations;
using CQRS.Features.Entities;
using CQRS.FeaturesData.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CQRS.FeaturesData.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}