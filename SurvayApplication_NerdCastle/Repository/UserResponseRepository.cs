using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Interface;
using SurvayApplication_NerdCastle.Models;

namespace SurvayApplication_NerdCastle.Repository
{
    public class UserResponseRepository : IRepository<UserResponse>
    {

        public SurveyDbContext _context;
        public UserResponseRepository(SurveyDbContext context)
        {
            _context = context;
        }
        public bool Add(UserResponse entity)
        {
            _context.UserResponses.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var product = _context.UserResponses.FirstOrDefault(s => s.SurveyId == id);
            if (product != null)
            {
                product.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public List<UserResponse> GetAll()
        {
            return _context.UserResponses.Where(p => p.IsDeleted == false).ToList();
        }

        public UserResponse GetById(int id)
        {
            var survey = _context.UserResponses.Where(s => s.SurveyId == id).FirstOrDefault();

            return survey;
        }

        public bool Update(UserResponse entity)
        {
            _context.UserResponses.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
