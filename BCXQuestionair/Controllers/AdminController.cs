using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using BCXQuestionair.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BCXQuestionair.Controllers
{
    public class AdminController : Controller
    {

        //initiate context
        private ApplicationDbContext _context;
        public AdminController()
        {
            _context = new ApplicationDbContext();

        }

        //To displose of the _context
        protected override void Dispose(bool Disposing)
        {
            _context.Dispose();
        }


        // GET: Admin/Tests
        //get the page of all the test that was done
        [Authorize]
        public ActionResult Tests()
        {
            var tests = _context.Test.Include(t => t.TestAnswers).ToList();

            return View(tests);
        }

        // GET: Admin/Questions
        //Get the list of all the questions
        [Authorize]
        public ActionResult Questions()
        {
            var questions = _context.Question.Include(q => q.Options).Include(q => q.QuestionType).ToList();

            return View(questions);
        }

        // GET: Admin/QuestionAdd
        //Get the page where you can add a new question
        [Authorize]
        public ActionResult QuestionAdd()
        {
            var questionTypes = _context.QuestionType.ToList();
            return View(questionTypes);
        }
        // Post: Admin/CreateQuestion
        // A method to actually create the data and save it to the database

        [Authorize]
        [HttpPost]
        public ActionResult CreateQuestion()
        {
            int questionTypeId = int.Parse(HttpContext.Request.Form["QuestionType_Id"]);

            // Get the question type model in order to continue saving
            var questionType = _context.QuestionType.SingleOrDefault(q => q.Id == questionTypeId);

            var question = new Question { QuestionString = HttpContext.Request.Form["QuestionString"].ToString(), QuestionType = questionType };
            _context.Question.Add(question);
            _context.SaveChanges();

            // get json encoded options from input field
            var jsonOptions = HttpContext.Request.Form["questionOptionsInput"].ToString();

            // convert jsonOptions to a c# array
            var questionOptions = JValue.Parse(jsonOptions);

            foreach (var option in questionOptions)
            {
                var questionOption = new QuestionOption { Option = (string)option, Question = question };
                _context.QuestionOption.Add(questionOption);
                _context.SaveChanges();
            }

            return RedirectToAction("Questions");
        }

        // GET: Admin/QuestionDelete/{id}   
        // To delete a question when it's not needed anymore, as well as all the Question Options that comes with it.
        [Authorize]
        public ActionResult QuestionDelete(int id)
        {
            var question = _context.Question
                  .Where(q => q.Id == id)
                  .Include(q => q.Options);
            _context.Question.RemoveRange(question);
            _context.SaveChanges();

            return RedirectToAction("Questions");
        }

        // GET: Admin/ExportTestToJson/{id}        
        // Shows the JSON data of each test with it's answers
        [Authorize]
        public ActionResult ExportTestToJson(int id)
        {
            var test = _context.Test
                  .Where(q => q.Id == id)
                  //.Include(q => q.TestAnswers)
                  .Include(q => q.TestAnswers)
                  .FirstOrDefault();

            var list = JsonConvert.SerializeObject(test,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
        }       
    }
}
