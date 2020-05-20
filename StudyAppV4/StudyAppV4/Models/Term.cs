using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyAppV4.Models
{
    public class Term
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Terms { get; set; }
        public string Definitions { get; set; }
        public string Questions { get; set; }
        public string Answers { get; set; }
    }
}
