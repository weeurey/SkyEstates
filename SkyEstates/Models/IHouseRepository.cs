using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
//Interface class defining all the methods available
{
    public interface IHouseRepository
    {

        IEnumerable<House> GetAllHouses();
        House GetHouseByID(int HouseId);
    }
}
