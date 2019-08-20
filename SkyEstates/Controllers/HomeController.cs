using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SkyEstates.Models;
using SkyEstates.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyEstates.Controllers
{
    public class HomeController : Controller
    {


        private readonly IHouseRepository _houseRepository;
        private readonly IEnquiryRepository _enquiryRepository;


        public HomeController(IHouseRepository houseRepository, IEnquiryRepository enquiryRepository)
        {
            _houseRepository = houseRepository;
            _enquiryRepository = enquiryRepository;


        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var houses = _houseRepository.GetAllHouses().OrderBy(p => p.Id);


            //create object containing needed data and return it to view
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to SkyEstates",
                Houses = houses.ToList()

            };

            return View(homeViewModel);
        }

        //must be logged in
        [Authorize]
        public IActionResult MyEnquiry()
        {
            //Grab our needed data
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var houses = _houseRepository.GetAllHouses().OrderBy(p => p.Id);
            //we only need the enquirys relating to the user
            var enquirys = _enquiryRepository.GetEnquiryByUserID(userId);


            //create object containing our needed data and return it to the view
            var enquiryViewModel = new EnquiryViewModel()
            {
                Title = "Here are all your current enquiries",
                Houses = houses.ToList(),
                Enquiries = enquirys.ToList()

            };

            return View(enquiryViewModel);

        }

            // Home/Details
            public IActionResult Details(int id)
        {
            //get data on house that it has been passed by the id from view and get the corrisponding house
            var house = _houseRepository.GetHouseByID(id);
            if (house == null)
            {
                return NotFound();
            }

            return View(house);
        }

        //must be logged in
        [Authorize]
        public IActionResult AllEnquiry(int id)
        {
            //get logged in users id
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //if the user id is the correct id of the local admin             or web app admin then allow them access
            if (userId == "5522117f-b819-45aa-85a3-d316af1717b5" || userId == "a03605d5-8298-4ef6-bdb2-b86988459297")
            {
                var houses = _houseRepository.GetAllHouses().OrderBy(p => p.Id);
                var enquirys = _enquiryRepository.GetAllEnquiry();

                //create object and pass it to the view
                    var enquiryViewModel = new EnquiryViewModel()
                       {
                         Title = "All enquiries are listed below",
                         Houses = houses.ToList(),
                         Enquiries = enquirys.ToList()

                        };

                //No error to be bassed in viewbag
                ViewBag.Error = "";
                            return View(enquiryViewModel);

            }
            //user is not an admin and will be retuned this error
            ViewBag.Error = "You are not an admin.";

            return View();
            
        }
    }
}
