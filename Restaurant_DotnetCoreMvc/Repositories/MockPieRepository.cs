using System.Collections.Generic;
using System.Linq;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class MockPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie> {
            new Pie {Id = 1,Name="Fruit Pie",Description="aaaa",Price="20.5M",ImageUrl="",ImageThumbnailUrl="https://157212-453144-1-raikfcquaxqncofqfm.stackpathdns.com/wp-content/uploads/2012/09/classic-meat-pies-2.jpg",IsPieOfTheWeek=true,Category=null},
            new Pie {Id = 1,Name="Fruit Pie",Description="aaaa",Price="20.5M",ImageUrl="",ImageThumbnailUrl="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/assorted-homemade-autumn-pies-table-scene-on-a-royalty-free-image-1636139025.jpg?crop=1.00xw:0.750xh;0,0.123xh&resize=980:*",IsPieOfTheWeek=true,Category=null},
            new Pie {Id = 1,Name="Fruit Pie",Description="aaaa",Price="20.5M",ImageUrl="",ImageThumbnailUrl="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1636131753-09212020_PDP-OVERHAUL6032.jpg?crop=1xw:1.00xh;center,top&resize=768:*",IsPieOfTheWeek=true,Category=null},
            new Pie {Id = 1,Name="Fruit Pie",Description="aaaa",Price="20.5M",ImageUrl="",ImageThumbnailUrl="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1636134031-three-berry-pie.eb4c0d47198240b58e30d6fa16279141.jpg?crop=1xw:1xh;center,top&resize=768:*",IsPieOfTheWeek=true,Category=null}

        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int Id)
        {
            return AllPies.FirstOrDefault(p => p.Id == Id);
        }
    }
}
