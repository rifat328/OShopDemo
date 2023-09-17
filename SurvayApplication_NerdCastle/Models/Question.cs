namespace SurvayApplication_NerdCastle.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int SurveyId { get; set; }
        public string QuestionText { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property to Survey
        public Survey Survey { get; set; }

        // Navigation property to PossibleAnswer
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
    }
}
