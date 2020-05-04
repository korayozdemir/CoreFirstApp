using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            ProductRepository.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}