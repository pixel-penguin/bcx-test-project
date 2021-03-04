using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using BCXQuestionair.Models;

namespace BCXQuestionair.Controllers
{
    public class QuestionsController : Controller
    {

        // initiate context of the db application
        private ApplicationDbContext _context;
               

        public QuestionsController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool Disposing)
        {
            _context.Dispose();
        }

        // GET: / or Questions/Index
        // Create the questionair for the students to do
        public ActionResult Index()
        {
            var questions = _context.Question.Include(q => q.Options).Include(q => q.QuestionType).ToList();
            questions.ForEach(Console.WriteLine);

            return View(questions);
        }

        // Post: Questions/Create
        // Saves the data of the questionair
        [HttpPost]
        public ActionResult Create(Test input)
        {
            int timeSpent = int.Parse(HttpContext.Request.Form["timeSpent"]);


            var test = new Test { Email = HttpContext.Request.Form["email"].ToString(), TimeinSeconds = timeSpent };
            var totalQuestions = int.Parse(HttpContext.Request.Form["totalQuestions"]);

            _context.Test.Add(test);
            _context.SaveChanges();


            
            /* 
             * on the form itself I created a hidden field where I can see the total questions
             * I'm looping through each one and get the original question from it as well
             * I chose not to link the tests with questions or with the question options, otherwise it might make issues when deleting questions with options.             
             */ 
             
            for (int i = 1; i <= totalQuestions; i++)
            {

                int questionId = int.Parse(HttpContext.Request.Form["questionId" + i]);

                var question = _context.Question.SingleOrDefault(q => q.Id == questionId);

                var answer = new TestAnswer { QuestionText = question.QuestionString, AnswerText = HttpContext.Request.Form["questionInput" + i].ToString(), Test = test };

                _context.TestAnswer.Add(answer);
                _context.SaveChanges();


            }

            // Redirecting away from the route, otherwise it will continue submitting info when refreshing the page
            return RedirectToAction("Done");

        }

        // Get: Questions/Done
        public ActionResult Done()
        {
            return View();
        }

    }
}