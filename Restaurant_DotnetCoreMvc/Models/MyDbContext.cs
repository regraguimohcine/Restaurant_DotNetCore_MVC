
using Microsoft.EntityFrameworkCore;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopingCardItem> ShopingCards { get; set; }

    }
}
