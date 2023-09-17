using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Models;
using static SurvayApplication_NerdCastle.Repository.SurvayRepository;

namespace SurvayApplication_NerdCastle.Repository
{
    public class SurvayRepository
    {
        public class ProductRepository 
        {
            public SurvayDbContext _context;
            public ProductRepository(SurvayDbContext dbContext)
            {
                _context = dbContext;
            }
            public bool Add(Survey survey)
            {
                _context.Surveys.Add(survey);
                return _context.SaveChanges() > 0;
            }

            public bool Delete(int id)
            {
                var product = _context.Surveys.FirstOrDefault(s => s.SurveyId == id);
                if (product != null)
                {
                    product.IsDeleted = true;
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }

            public bool Edit(Product product)
            {
                _context.Products.Update(product);
                return _context.SaveChanges() > 0;
            }

            public List<Product> GetAll()
            {
                return _context.Products.Where(p => p.IsDeleted == false).ToList();
            }

            public Product GetProduct(int id)
            {
                var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();

                return product;
            }

            public Product GetProductByName(string product)
            {
                var Product = _context.Products.Where(p => p.Name == product).FirstOrDefault();
                if (Product != null)
                {
                    return null;
                }
                return Product;
            }
        }
    }
}
}
