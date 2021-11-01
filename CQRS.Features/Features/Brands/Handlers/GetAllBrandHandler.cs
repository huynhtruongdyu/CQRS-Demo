using CQRS.Features.Brands.Queries;
using CQRS.Features.Entities;
using CQRS.FeaturesData.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Features.Brands.Handlers
{
    public class GetAllBrandHandler : IRequestHandler<GetAllBrandQuery, List<Brand>>
    {
        private readonly AppDbContext _context;

        public GetAllBrandHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Brand>> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
        {
            return _context.Brands.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}