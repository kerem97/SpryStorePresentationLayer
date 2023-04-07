using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Areas.Catalog.Controllers
{

    [Area("Catalog")]
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Contact c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.TInsert(c);
            return RedirectToAction("Product","Index");
        }
    }
}
