using CarOLiner.Services.Features.Products;
using CarOLiner.Shared.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarOLiner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetAllProducts()
        {
            // TODO: Return all products to a view
            var productResponses = await _productService.GetAllProducts();
            if (productResponses != null)
            {
                return Ok(productResponses);
            }
            else
            {
                return BadRequest(productResponses);
            }
        }
    }
}
