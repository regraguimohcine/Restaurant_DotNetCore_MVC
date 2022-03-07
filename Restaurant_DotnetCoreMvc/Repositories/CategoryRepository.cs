using System.Collections.Generic;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyDbContext _context;

        public CategoryRepository(MyDbContext dbcontext)
        {
            _context = dbcontext;
        }
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return _context.Categories;
            }
        }
    }
}
