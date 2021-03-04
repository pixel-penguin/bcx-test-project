using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCXQuestionair.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public int TimeinSeconds { get; set; }

        public ICollection<TestAnswer> TestAnswers { get; set; }

    }
}