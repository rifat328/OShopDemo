using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Models;

namespace OnlineShop.API.DataContext
{
    public class OShopDbContext:DbContext
    {
        public OShopDbContext(DbContextOptions<OShopDbContext> options):base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
