using CQRS.Features.Entities;
using MediatR;
using System.Collections.Generic;

namespace CQRS.Features.Brands.Queries
{
    public record GetAllBrandQuery : IRequest<List<Brand>>;
}