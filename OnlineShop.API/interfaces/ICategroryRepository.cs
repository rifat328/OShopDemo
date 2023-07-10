using OnlineShop.API.Models;

namespace OnlineShop.API.interfaces
{
    public interface ICategroryRepository
    {
        List<Category> GetAll();
        Category GetCategory(int id);
        bool Add(Category category);
        bool Edit(Category category);
        bool Delete(int id);
    }
}
