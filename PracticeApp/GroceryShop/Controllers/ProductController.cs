using GroceryShopCore.IServices;
using GroceryShopData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(ProductDTO productDTO)
        {
            _productRepository.CreateProduct(productDTO);
            return Ok("Product created Successfully");
        }

        [HttpPut("UpdateProduct")]
        public IActionResult EditProductById(string productId, ProductDTO productDTO)
        {
            _productRepository.UpdateProduct(productId, productDTO);
            return Ok("Updated successfully");

        }
        [HttpGet("GetProductById")]
        public IActionResult GetProductById(string productId)
        {
            var product = _productRepository.GetProductById(productId);
            return Ok(product);
        }

        [HttpGet("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            var product = _productRepository.GetAllProduct();
            return Ok(product);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(string productId) 
        { 
            _productRepository.DeleteProduct(productId);
            return Ok("Product deleted successfully");
        }
    }
}
