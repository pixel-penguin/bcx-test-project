using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCXQuestionair.Models
{
    public class TestAnswer
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public Test Test { get; set; }
    }
}