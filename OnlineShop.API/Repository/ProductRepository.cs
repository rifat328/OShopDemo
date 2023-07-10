using Microsoft.EntityFrameworkCore;
using OnlineShop.API.DataContext;
using OnlineShop.API.interfaces;
using OnlineShop.API.Models;

namespace OnlineShop.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        OShopDbContext _dbContext;
        public ProductRepository(OShopDbContext dbContext)
        { 
            _dbContext = dbContext;
        }
        public bool Add(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(c=>c.Id == id);
            if(product != null)
            {
                product.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool Edit(Product product)
        {
            _dbContext.Products.Update(product);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.Include(c=>c.Category)
                .Where(c=>!c.IsDeleted)
                .ToList();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(c => c.Id == id);
        }
    }
}
