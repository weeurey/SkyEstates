using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkyEstates.Models;
using SkyEstates.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyEstates.Controllers
{
    public class HomeController : Controller
    {


        private readonly IHouseRepository _houseRepository;

        public HomeController(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;

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
