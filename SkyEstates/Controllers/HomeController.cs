﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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


            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to SkyEstates",
                Houses = houses.ToList()

            };

            return View(homeViewModel);
        }

        [Authorize]
        public IActionResult MyEnquiry()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var houses = _houseRepository.GetAllHouses().OrderBy(p => p.Id);
            var enquirys = _enquiryRepository.GetEnquiryByUserID(userId);//.OrderBy(p => p.Id);



            var enquiryViewModel = new EnquiryViewModel()
            {
                Title = "Here are all your current enquiries",
                Houses = houses.ToList(),
                Enquiries = enquirys.ToList()

            };

            return View(enquiryViewModel);

        }

            public IActionResult Details(int id)
        {
            var house = _houseRepository.GetHouseByID(id);
            if (house == null)
            {
                return NotFound();
            }

            return View(house);
        }
    }
}
