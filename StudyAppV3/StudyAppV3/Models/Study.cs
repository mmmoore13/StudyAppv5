using System;
using System.ComponentModel.DataAnnotations;

namespace StudyAppV2.Models
{
    public class Study
    {
        public int ID { get; set; }
    }

    public class User : Study
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ForgettingRate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Reminder { get; set; }
    }

    public class Answer : Study
    {
        private int AnswerID { get; set; }
        public string Answers { get; set; }
    }

    public class Question : Answer
    {
        private int QuestionID { get; set; }
        public string Questions { get; set; }
        [DataType(DataType.Date)]
        private DateTime LastReview { get; set; }
    }

    public class Definition : Question
    {
        private int DefinitionID { get; set; }
        public string Definitions { get; set; }
    }

    public class Term : Definition
    {
        private int TermID { get; set; }
        public string Terms { get; set; }
        public string Subject { get; set; }
    }
}
