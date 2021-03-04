using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCXQuestionair.Models
{
    public class QuestionOption
    {
        public int Id { get; set; }

        //if question has multiple answers, this will be one of the options
        public string Option { get; set; }

        public Question Question { get; set; }
    }
}