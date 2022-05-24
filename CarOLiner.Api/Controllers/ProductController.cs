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

        [HttpGet("{productId}")]
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

        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductRequest productRequest)
        {
            // TODO: Add a product 
            var productResponse = await _productService.CreateProduct(productRequest);
            if (productResponse != null)
            {
                return Ok(productResponse);
            }
            else
            {
                return BadRequest(productResponse);
            }
        }

        [HttpPut]
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

        [HttpDelete]
        public async Task<ActionResult> DeleteProductById(Guid productId)
        {
            // TODO: Delete one specific product with Guid
            var productResponses = await _productService.DeleteProduct(productId);
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
