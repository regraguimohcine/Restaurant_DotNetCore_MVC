using System.Collections.Generic;

namespace Restaurant_DotnetCoreMvc.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

        
    }
}
