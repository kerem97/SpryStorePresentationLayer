using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.ViewComponents.Contact
{
    public class ContactMapLocation:ViewComponent
    {
        private readonly IAdressService _adressService;

        public ContactMapLocation(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _adressService.TGetList();
            return View(values);
        }
    }
}
