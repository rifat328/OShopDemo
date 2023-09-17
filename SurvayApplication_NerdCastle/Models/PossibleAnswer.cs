namespace SurvayApplication_NerdCastle.Models
{
    public class PossibleAnswer
    {
        public int PossibleAnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property to Question
        public Question Question { get; set; }
    }
}
