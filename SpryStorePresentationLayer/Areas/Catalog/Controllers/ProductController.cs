using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetProductListWithCategory();
            return View(values);
        }
    }
}
