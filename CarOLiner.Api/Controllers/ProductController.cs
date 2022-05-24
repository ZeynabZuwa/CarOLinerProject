using CarOLiner.Services.Features.Products;
using CarOLiner.Shared.RequestModels;
using CarOLiner.Shared.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarOLiner.Api.Controllers
{
    [Route("[controller]")]
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
            // TODO: Return all products
            var productResponse = await _productService.GetAllProducts();
            if (productResponse != null && productResponse.Count > 0)
            {
                return Ok(productResponse);
            }
            else
            {
                return BadRequest(productResponse);
            }
        }

        [HttpGet("{}")]
        public async Task<ActionResult<ProductResponse>> GetProductById(Guid productId)
        {
            // TODO: Return one specific product with Guid
            var productResponses = await _productService.GetProductById(productId);
            if (productResponses != null)
            {
                return Ok(productResponses);
            }
            else
            {
                return BadRequest(productResponses);
            }
        }

        [HttpPut("{}")]
        public async Task<ActionResult> UpdateProduct(ProductRequest productRequest)
        {
            // TODO: Delete one specific product with Guid
            var productResponse = await _productService.UpdateProduct(productRequest);
            if (productResponse != null)
            {
                return Ok(productResponse);
            }
            else
            {
                return BadRequest(productResponse);
            }
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult> DeleteProductById(Guid productId)
        {
            // TODO: Delete one specific product with Guid
            var productResponses = await _productService.GetProductById(productId);
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
