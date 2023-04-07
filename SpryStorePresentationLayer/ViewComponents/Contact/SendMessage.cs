using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
