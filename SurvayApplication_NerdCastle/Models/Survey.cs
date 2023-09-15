namespace SurvayApplication_NerdCastle.Models
{
    public class Survey
    {
        
        
            public int SurveyId { get; set; }
            public string ImageUrl { get; set; }
            public string Question { get; set; }
            public DateTime Date { get; set; }

            // Navigation property to Question
            public ICollection<Question> Questions { get; set; }
        
    }
}
