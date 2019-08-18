using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
{
    public class MockHouseRepository:IHouseRepository
    {
        private List<House> _houses;

        public MockHouseRepository()
        {
            if (_houses == null)
            {
                InitializeHouses();
            }
        }

        private void InitializeHouses()
        {
            _houses = new List<House>
        {
            new House {Id = 1, Name = "5 Bedroom Villa",
                Price = 12.95M,
                ShortDescription = "Amazing 5 Bedroom Home with Swimming Pool!",
                LongDescription = "Amazing looking 5 bedroom house with FANTASTIC views including a swimming pool (pool needs to be inflated)",
                ImageUrl = "https://www.savvyfp.co.uk/wp-content/uploads/2017/09/Nice-house.jpg",
                IsHouseOfTheWeek = true,
                ImageThumbnailUrl = "https://www.savvyfp.co.uk/wp-content/uploads/2017/09/Nice-house.jpg"},

            new House {Id = 1, Name = "1 Basement Bedroom",
                Price = 12.95M,
                ShortDescription = "Tiny Wee basement bedroom",
                LongDescription = "Small dingy basement with a slight smell of cat pee)",
                ImageUrl = "https://www.burnettpainting.com/wp-content/uploads/2016/01/old-basement-before-and-after.jpg",
                IsHouseOfTheWeek = true,
                ImageThumbnailUrl = "https://www.burnettpainting.com/wp-content/uploads/2016/01/old-basement-before-and-after.jpg"},

            new House {Id = 1, Name = "Caravan",
                Price = 12.95M,
                ShortDescription = "Caravan with No Wheels",
                LongDescription = "A Caravan in perfect working order, imacculate apart from the lack of wheels... AND NO ITS NOT THE ONE STOLEN FROM GREENWAY!",
                ImageUrl = "http://www.caravantimes.co.uk/photo/we-take-a-look-into-the-scammers-in-the-caravan-world--$14113632$326.jpg",
                IsHouseOfTheWeek = true,
                ImageThumbnailUrl = "http://www.caravantimes.co.uk/photo/we-take-a-look-into-the-scammers-in-the-caravan-world--$14113632$326.jpg"},



            };
        }

        public IEnumerable<House> GetAllHouses()
        {
            return _houses;
        }

        public House GetHouseByID(int houseId)
        {
            return _houses.FirstOrDefault(h => h.Id == houseId);
        }


    }
}
