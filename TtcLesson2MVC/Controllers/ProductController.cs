using Microsoft.AspNetCore.Mvc;
using TtcLesson2MVC.Models;

namespace TtcLesson2MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
        List<Product> products = new List<Product>()
            {
                new Product { id = 1, name = "Product 1", price = 500000, createdAt = new DateTime(2020, 12, 25), image = "/images/product1.jpg"},
                new Product { id = 2, name = "Product 2", price = 700000, createdAt = new DateTime(2020, 12, 25), image = "/images/product2.jpg"},
                new Product { id = 3, name = "Product 3", price = 550000, createdAt = new DateTime(2020, 12, 25), image = "/images/product3.jpg"},
                new Product { id = 4, name = "Product 4", price = 550000, createdAt = new DateTime(2020, 12, 25), image = "/images/product4.jpg"}
            };

        return View(products);
        }
    }
}
