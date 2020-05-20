using System;
using System.ComponentModel.DataAnnotations;

namespace StudyApp.Models
{
    public class Study
    {
        public int ID { get; set; }

    }

    public class User
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
        public int ID { get; set; }

    }


    public class Answer
    {
        //public int AnswerID { get; set; }
        public string Answers { get; set; }
        //        [DataType(DataType.Date)]
        //        public DateTime DateCorrect { get; set; }
        //        public float TimeTaken { get; set; }
        //        public int Value { get; set; }
        //        public int QuestionID { get; set; }
        //        public int DefinitionID { get; set; }
        //        public int UserID { get; set; }
        //        public int ID { get; set; }
    }

    public class Question : Answer
    {
        //        public int QuestionID { get; set; }
        public string Questions { get; set; }
        //        [DataType(DataType.Date)]
        //        public DateTime DateReviewed { get; set; }
        //        public int DefinitionID { get; set; }
        //        public int UserID { get; set; }
        //        public int ID { get; set; }
    }
    //    public class Subject
    //    {
    //        public int SubjectID { get; set; }
    //        public string SubjectName { get; set; }
    //        public string DifficultyLevel { get; set; }
    //       public int ID { get; set; }
    //    }

    public class Definition : Question
    {
        //        public int DefinitionID { get; set; }
        public string Definitions { get; set; }
        //        public int TermID { get; set; }
        //        public int SubjectID { get; set; }
        //        public int UserID { get; set; }
        //        public int ID { get; set; }
    }

    public class Term : Definition
    {
        public int TermID { get; set; }
        public string Terms { get; set; }
        public string Subject { get; set; }
        //public string DifficultyLevel { get; set; }
        //public int SubjectID { get; set; }
        //public int UserID { get; set; }
        //public int ID { get; set; }
    }
}
