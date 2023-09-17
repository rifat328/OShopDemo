using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Models;

namespace SurvayApplication_NerdCastle.Repository
{
    public class QuestionRepository
    {
        public SurveyDbContext _context;
        public QuestionRepository(SurveyDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool AddQuestion(Question question)
        {
            _context.Questions.Add(question);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteQuestion(int questionId)
        {
            var product = _context.Questions.FirstOrDefault(s => s.SurveyId == questionId);
            if (product != null)
            {
                product.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public bool UpdateQuestion(Question question)
        {
            _context.Questions.Update(question);
            return _context.SaveChanges() > 0;
        }

        public List<Survey> GetAll()
        {
            return _context.Surveys.Where(p => p.IsDeleted == false).ToList();
        }

        public Question GetQuestionById(int questionId)
        {
            var q = _context.Questions.Where(s => s.QuestionId == questionId).FirstOrDefault();

            return q;
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
        public Question GetQuestionsBySurveyId(int surveyId)
        {
            var q = _context.Questions.Where(s => s.SurveyId == surveyId).FirstOrDefault();

            return q;
        }







    }
}
