using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
    //methods for getting the class data
{
    public class HouseRepository : IHouseRepository
    {

        private readonly AppDbContext _appDbContext;

        public HouseRepository(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;

        }

        public IEnumerable<House> GetAllHouses()
        {
            return _appDbContext.Houses;
        }

        public House GetHouseByID(int HouseId)
        {
            //only return houses with matching ID
            return _appDbContext.Houses.FirstOrDefault(p => p.Id == HouseId);
        }
    }
}
