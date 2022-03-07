using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly MyDbContext _context;

        public PieRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> AllPies
        {
            get 
            {
                return _context.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _context.Pies.Where(c => c.IsPieOfTheWeek == true).Include(c => c.Category);
            }
        }

        public Pie CreatePie(Pie p)
        {
            _context.Pies.Add(p);
            _context.SaveChanges();
            return p;
        }

        public Pie GetPieById(int Id)
        {
            return _context.Pies.Include(c=>c.Category).SingleOrDefault(x=>x.Id==Id);
        }
    }
}
