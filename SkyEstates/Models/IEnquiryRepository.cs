using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
    //Interface class defining all the methods available
{
    public interface IEnquiryRepository
    {
        IEnumerable<Enquiry> GetAllEnquiry();
        void AddEnquiry(Enquiry enquiry);
        IEnumerable<Enquiry> GetEnquiryByUserID(string uID);

    }
}
