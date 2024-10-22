using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersService.Models;
using ProductService.Models;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>
    {
        new Order { Id = 1, OrderDate = DateTime.Now, CustomerName = "John Doe", Products = new List<Product> { new Product { Id = 1, Name = "Product A", Price = 10.0m } } }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get() => Ok(orders);
    }
}
