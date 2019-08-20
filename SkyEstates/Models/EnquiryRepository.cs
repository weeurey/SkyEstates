using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
    //methods for getting the data
{
    public class EnquiryRepository : IEnquiryRepository
    {
        private readonly AppDbContext _appDbContext;


        public EnquiryRepository(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }


        public IEnumerable<Enquiry> GetAllEnquiry()
        {
            return _appDbContext.Enquiries;
        }



        public void AddEnquiry(Enquiry enquiry)
        {
            _appDbContext.Enquiries.Add(enquiry);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Enquiry> GetEnquiryByUserID(string uID)

        {
            //get only enquires matching with the passed in uID
            return _appDbContext.Enquiries.Where(s => s.UserId == uID);
        }
    }
}
