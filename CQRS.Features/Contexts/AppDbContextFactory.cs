using CQRS.FeaturesData.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CQRS.Features.Contexts
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,5100;Database=cqrs;User Id=sa;password=Pass@word;Pooling=False");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}