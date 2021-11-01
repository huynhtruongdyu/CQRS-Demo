using CQRS.Features.Entities;
using CQRS.Features.Features.Brands.Commands;
using CQRS.FeaturesData.Contexts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Features.Features.Brands.Handlers
{
    public class CreateNewBrandHandler : IRequestHandler<CreateNewBrandCommand, Brand>
    {
        private readonly AppDbContext _context;

        public CreateNewBrandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Brand> Handle(CreateNewBrandCommand request, CancellationToken cancellationToken)
        {
            _context.Brands.Add(request.brand);
            _context.SaveChanges();
            return await Task.FromResult(request.brand);
        }
    }
}