using Microsoft.AspNetCore.Mvc;
using MVC_core8.Models;

namespace MVC_core8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
                 var products = new List<Product>
                 {
                    new Product { ProductId = 1, Name = "Product A", Price = 100 },
                    new Product { ProductId = 2, Name = "Product B", Price = 200 }
                 };

            return View(products);
        }

        public IActionResult Details( int? id )
        {
            var products = new List<Product>
                 {
                    new Product { ProductId = 1, Name = "Product A", Price = 100 },
                    new Product { ProductId = 2, Name = "Product B", Price = 200 }
                 };

            return View(products);
        }
    }
}
