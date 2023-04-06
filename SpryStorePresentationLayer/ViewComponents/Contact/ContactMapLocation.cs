using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.ViewComponents.Contact
{
    public class ContactMapLocation:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
