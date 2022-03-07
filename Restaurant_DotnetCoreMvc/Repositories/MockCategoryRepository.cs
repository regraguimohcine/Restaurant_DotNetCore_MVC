using System.Collections.Generic;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>{
            new Category {CategoryId = 1,CategoryName="Fruit Pie",CategoryDescription="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"},
            new Category {CategoryId = 1,CategoryName="Cheese cakes",CategoryDescription="bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"},
            new Category {CategoryId = 1,CategoryName="Seaasonal Pie",CategoryDescription="cccccccccccccccccccccccccc"},
        };
    }
}
