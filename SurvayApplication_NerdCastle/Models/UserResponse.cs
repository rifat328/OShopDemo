namespace SurvayApplication_NerdCastle.Models
{
    public class UserResponse
    {
        public int UserResponseId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string ChosenAnswer { get; set; }

        // Navigation properties
        public Survey Survey { get; set; }
        public Question Question { get; set; }
    }
}
