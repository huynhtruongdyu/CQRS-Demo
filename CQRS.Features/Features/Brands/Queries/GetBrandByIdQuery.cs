using CQRS.Features.Entities;
using MediatR;

namespace CQRS.Features.Features.Brands.Queries
{
    public record GetBrandByIdQuery(int Id) : IRequest<Brand>;
}