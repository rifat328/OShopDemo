using Microsoft.EntityFrameworkCore;
using SurvayApplication_NerdCastle.Models;

namespace SurvayApplication_NerdCastle.DataContext
{
    public class SurvayDbContext : DbContext
    {
        public SurvayDbContext(DbContextOptions<SurvayDbContext> options):base(options) 
        {
            
        }

       public DbSet<Survey> Surveys { get; set; }
        public DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }
    }
}
