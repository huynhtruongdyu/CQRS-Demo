using CQRS.Features.Entities;
using MediatR;

namespace CQRS.Features.Features.Brands.Commands
{
    public record CreateNewBrandCommand(Brand brand) : IRequest<Brand>;
}