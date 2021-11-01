using CQRS.Features.Entities;
using CQRS.Features.Features.Brands.Queries;
using CQRS.FeaturesData.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Features.Features.Brands.Handlers
{
    public class GetBrandByIdHandler : IRequestHandler<GetBrandByIdQuery, Brand>
    {
        private readonly AppDbContext _context;

        public GetBrandByIdHandler(AppDbContext context)
        {
            _context = context;
        }
        public Task<Brand> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            return _context.Brands.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
