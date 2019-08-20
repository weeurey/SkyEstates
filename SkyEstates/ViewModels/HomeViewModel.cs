using SkyEstates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.ViewModels
//Object used to sent data to the Home view

{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<House> Houses { get; set; }

    }
}
