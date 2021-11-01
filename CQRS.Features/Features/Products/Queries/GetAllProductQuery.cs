using CQRS.Features.Entities;
using MediatR;
using System.Collections.Generic;

namespace CQRS.Features.Features.Products.Queries
{
    public record GetAllProductQuery : IRequest<List<Product>>;
}