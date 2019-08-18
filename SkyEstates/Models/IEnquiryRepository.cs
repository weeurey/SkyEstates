using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
{
    public interface IEnquiryRepository
    {
        void AddEnquiry(Enquiry enquiry);

    }
}
