using Microsoft.AspNetCore.Mvc;
using SpryStoreBusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Areas.Catalog.Controllers
{

    [Area("Catalog")]
    public class AboutController : Controller
    {
        private readonly IEmployeeService _employeeService;
    

        public AboutController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
      
        }

        public IActionResult Index()
        {
            var values = _employeeService.TGetList();
            return View(values);
        }

        public PartialViewResult PartialAboutCover()
        {
            return PartialView();
        }

        public PartialViewResult PartialAboutWhatWeDo()
        {
            return PartialView();
        }

        public PartialViewResult PartialAboutOurTeam()
        {

            return PartialView();
        }

        public PartialViewResult PartialServices()
        {
            //var values = _serviceService.TGetList();
            //return PartialView(values);
            return PartialView();
        }

        public PartialViewResult PartialHappyPartners()
        {
            //var values = _partnerService.TGetList();
            //return PartialView(values);
            return PartialView();
        }
    }
}
