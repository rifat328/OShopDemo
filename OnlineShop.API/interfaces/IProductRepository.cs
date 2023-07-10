using OnlineShop.API.Models;

namespace OnlineShop.API.interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProduct(int id);
        bool Add(Product product);
        bool Edit(Product product);
        bool Delete(int id);
    }
}
