using Microsoft.EntityFrameworkCore;
using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Interface;
using SurvayApplication_NerdCastle.Models;

namespace SurvayApplication_NerdCastle.Repository
{
    public class PossibleAnswerRepository : IRepository<PossibleAnswer>
    {
        public SurveyDbContext _context;
        public PossibleAnswerRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public bool Add(PossibleAnswer entity)
        {
            _context.PossibleAnswers.Add(entity);
            return  _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var product = _context.PossibleAnswers.FirstOrDefault(s => s.PossibleAnswerId == id);
            if (product != null)
            {
                product.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public List<PossibleAnswer> GetAll()
        {
            return _context.PossibleAnswers.Where(p => p.IsDeleted == false).ToList();
        }

        public PossibleAnswer GetById(int id)
        {

            var p = _context.PossibleAnswers.Where(s => s.PossibleAnswerId == id).FirstOrDefault();

            return p;
        }

        public bool Update(PossibleAnswer entity)
        {
            _context.PossibleAnswers.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
