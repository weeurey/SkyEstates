using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkyEstates.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyEstates.Controllers
{
    public class EnquiryController : Controller
    {

        private readonly IEnquiryRepository _enquiryRepository;
        

        public EnquiryController(IEnquiryRepository enquiryRepository)
        {
            _enquiryRepository = enquiryRepository;
        }
// GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Enquiry enquiry)
        {
            if (ModelState.IsValid)
            {
            _enquiryRepository.AddEnquiry(enquiry);
            //returns the Iaction of enq comp
            return RedirectToAction("EnquiryComplete");

            }
            return View(enquiry);

        }

        public IActionResult EnquiryComplete()
        {
            return View();
        }
    }
}
