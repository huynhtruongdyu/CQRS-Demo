using System.ComponentModel.DataAnnotations;

namespace CQRS.Features.DTOs.Brands
{
    public class BrandCreateReqModel
    {
        [Required]
        public string Name { get; set; }
    }
}