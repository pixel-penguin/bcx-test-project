using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCXQuestionair.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionString { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<QuestionOption> Options { get; set; }

    }
}