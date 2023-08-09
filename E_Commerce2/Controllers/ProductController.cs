using E_Commerce2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Products()
        {
            return View(_productService.GetAllProducts());
        }
    }
}
