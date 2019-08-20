using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyEstates.Models
    //class that sets up some basic content if none is found
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Houses.Any())
            {
                context.AddRange
                (
                    new House { Name = "Caravan", Price = 100, ShortDescription = "Caravan in perfect working order", LongDescription = "Caravan well used, but looked after! Perfect working order! Not needed any more - WW", ImageUrl = "http://www.doityourselfrv.com/wp-content/uploads/2016/04/breaking-bad-sunset.jpg", IsHouseOfTheWeek = false, ImageThumbnailUrl = "http://www.doityourselfrv.com/wp-content/uploads/2016/04/breaking-bad-sunset.jpg" },
                    new House { Name = "Basement", Price = 70, ShortDescription = "Basement Room for sale, clean and tidy", LongDescription = "Will be available from next week as previous tennent has to be <strike>mopped up</strike> moved out", ImageUrl = "http://st.houzz.com/simgs/0bf187c903ac9430_8-9062/-.jpg", IsHouseOfTheWeek = false, ImageThumbnailUrl = "http://st.houzz.com/simgs/0bf187c903ac9430_8-9062/-.jpg" },
                    new House { Name = "Graveyard Shed", Price = 200, ShortDescription = "Newly built shed in graveyard", LongDescription = "Newly built but ended up unused, you can probably fit a matress in here if you cut it in half. Dont mind any late-night noises its probably the grave diggers.", ImageUrl = "http://stpaulinus.co.uk/wp-content/uploads/2016/01/New-Shed-1.jpg", IsHouseOfTheWeek = false, ImageThumbnailUrl = "http://stpaulinus.co.uk/wp-content/uploads/2016/01/New-Shed-1.jpg" },
                    new House { Name = "Tree House", Price = 25, ShortDescription = "Wooden Handbuilt Treehouse", LongDescription = "Brillaint tree house used by both my daughter and son. Please be carfull as it was built by my husband", ImageUrl = "https://i.imgur.com/MgCh3Tr.png", IsHouseOfTheWeek = true, ImageThumbnailUrl = "https://i.imgur.com/MgCh3Tr.png" },
                    new House { Name = "Greenouse", Price = 340, ShortDescription = " 'Hot' property", LongDescription = "Perfect for those wanting a tan! But remember, don't throw stones in glass houses", ImageUrl = "https://www.gardensite.co.uk/images/thumbs/database_images/juliana-premium-dwarf-wall-9-x-14-ft-greenhouse-5fd606a96a7c3d91947d8d06706aa050_original.jpg", IsHouseOfTheWeek = false, ImageThumbnailUrl = "https://www.gardensite.co.uk/images/thumbs/database_images/juliana-premium-dwarf-wall-9-x-14-ft-greenhouse-5fd606a96a7c3d91947d8d06706aa050_original.jpg" },
                    new House { Name = "Cupbord", Price = 220, ShortDescription = "Spacious and Cosy", LongDescription = "Used by my good for nothing nephew, Harry, for 12 years, have moved him into a proper room now, looking for a lodger", ImageUrl = "https://i.pinimg.com/originals/0a/65/03/0a6503effe7da56ab47e3b7d8f57c147.jpg", IsHouseOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/originals/0a/65/03/0a6503effe7da56ab47e3b7d8f57c147.jpg" }
                    


                    );
            }
            context.SaveChanges();
        }
    }
}
