using SkyEstates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.ViewModels
{
    public class EnquiryViewModel
    {
        public string Title { get; set; }
        public List<House> Houses { get; set; }
        public List<Enquiry> Enquiries { get; set; }
    }
}
