using Microsoft.AspNetCore.Mvc;
using SpryStoreDataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.categoryCount = c.Categories.Count();
            ViewBag.productCount = c.Products.Count();
            ViewBag.electricProductCount = c.Products.Where(x => x.Category.CategoryName == "Elektronik").Count();
            ViewBag.priceUnder5000 = c.Products.Where(x => x.ProductPrice <= 5000).Count();
            ViewBag.avgPrice = c.Products.Average(x => x.ProductPrice);

            return View();
        }
    }
}
