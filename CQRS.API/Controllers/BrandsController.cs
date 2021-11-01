using CQRS.Features.Brands.Queries;
using CQRS.Features.DTOs.Brands;
using CQRS.Features.Entities;
using CQRS.Features.Features.Brands.Commands;
using CQRS.Features.Features.Brands.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrand()
        {
            List<Brand> brands = await _mediator.Send(new GetAllBrandQuery());
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int? id)
        {
            if (id.HasValue)
            {
                Brand brand = await _mediator.Send(new GetBrandByIdQuery(id.Value));
                return Ok(brand);
            }
            else
            {
                return NotFound("Id not found");
            }
        }

        [HttpPost("/create")]
        public async Task<IActionResult> CreateNewBrand([FromBody] BrandCreateReqModel model)
        {
            if (ModelState.IsValid)
            {
                Brand brandFromModel = new() { Name = model.Name };
                Brand newBrand = await _mediator.Send(new CreateNewBrandCommand(brandFromModel));
                return Ok(newBrand);
            }
            else
            {
                var message = string.Join(" | ", ModelState.Values
                                       .SelectMany(v => v.Errors)
                                       .Select(e => e.ErrorMessage));
                return BadRequest(message);
            }
        }
    }
}