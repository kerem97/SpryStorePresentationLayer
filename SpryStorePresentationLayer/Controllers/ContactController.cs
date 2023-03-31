using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using SpryStoreBusinessLayer.ValidationRules.ContactValidationRules;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
        [HttpGet]

        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddContact(Contact c)
        {
            ContactAddValidator validationRules = new ContactAddValidator();
            ValidationResult result = validationRules.Validate(c);
            if (result.IsValid)
            {
                c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                _contactService.TInsert(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
        }
    }
}
