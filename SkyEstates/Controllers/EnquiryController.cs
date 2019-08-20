using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyEstates.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyEstates.Controllers
    //Must be Logged in
{        [Authorize]


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

        //Get the data from post
        [HttpPost]
        public IActionResult Index(Enquiry enquiry)
        {
            if (ModelState.IsValid)
            {
                //Get ID of logged in user and set it
             var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                enquiry.UserId = userId;

                _enquiryRepository.AddEnquiry(enquiry);
            //returns the Iaction of enq comp
            return RedirectToAction("EnquiryComplete");

            }
            return View(enquiry);

        }

        public IActionResult EnquiryComplete()
        {
            //Returns a thank you message
            return View();
        }
    }
}
