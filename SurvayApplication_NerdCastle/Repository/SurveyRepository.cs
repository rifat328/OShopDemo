using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Models;
using static SurvayApplication_NerdCastle.Repository.SurveyRepository;

namespace SurvayApplication_NerdCastle.Repository
{
    public class SurveyRepository
    {
        

            public SurveyDbContext _context;
            public SurveyRepository(SurveyDbContext dbContext)
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

            public bool Edit(Survey survey)
            {
                _context.Surveys.Update(survey);
                return _context.SaveChanges() > 0;
            }

            public List<Survey> GetAll()
            {
                return _context.Surveys.Where(p => p.IsDeleted == false).ToList();
            }

            public Survey GetSurvey(int id)
            {
                var survey = _context.Surveys.Where(s => s.SurveyId == id).FirstOrDefault();

                return survey;
            }

            public Survey GetSurveyByFirstLetter(string product)
            {
                var Survey = _context.Surveys.Where(s => s.Question == product).FirstOrDefault();
                if (Survey != null)
                {
                    return Survey;
                }
                return null;
            }
        
    }
}

