using CQRS.Features.Entities;
using CQRS.Features.Features.Products.Queries;
using CQRS.FeaturesData.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Features.Features.Products.Handlers
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<Product>>
    {
        private readonly AppDbContext _context;

        public GetAllProductHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return _context.Products.ToListAsync();
        }
    }
}