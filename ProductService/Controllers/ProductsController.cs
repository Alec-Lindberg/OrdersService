using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.0m },
            new Product { Id = 2, Name = "Product B", Price = 20.0m }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get() => Ok(products);
    }
}
