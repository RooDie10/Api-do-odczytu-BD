using Microsoft.AspNetCore.Mvc;
using test.Interfaces;
using test.Models;

namespace test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
       public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _productService.AddNewProduct(product);
            return Created("", product);
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            if  (_productService.DeleteProduct(id))
            {
                return Ok();
            }
            return NotFound();
            //jezeli jest to usuwamy i zwracamy metode return ok()
            //else return notFound()
        }
    }
}
