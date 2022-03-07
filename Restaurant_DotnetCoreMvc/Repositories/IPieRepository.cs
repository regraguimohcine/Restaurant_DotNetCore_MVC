using System.Collections.Generic;

namespace Restaurant_DotnetCoreMvc.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get;}
        Pie GetPieById(int Id);

        Pie CreatePie(Pie p);

    }
}
