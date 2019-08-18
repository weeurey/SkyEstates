using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
{
    public class Enquiry
    {
        [BindNever]
        public int EnquiryId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your message is required")]
        public string Message { get; set; }


        public string UserId { get; set; }

        public int HouseID { get; set; }





        //public bool ContactMe { get; set; }
    }
}
