using System.Web.Mvc;
using DAL.Repository_CRUD;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        static bool voted = false;

        //Data Connetions to each instance
        Account_Data_Operations AccountDb = new Account_Data_Operations();
        Review_Data_Operations ReviewDb = new Review_Data_Operations();
        Post_Data_Operations PostDb = new Post_Data_Operations();
        Question_Data_Operations QuestionDb = new Question_Data_Operations();
        Answer_Data_Operations AnswerDb = new Answer_Data_Operations();
        Tag_Data_Operations TagDb = new Tag_Data_Operations();
        

        //Start page
        public ActionResult Index()
        {
            return View();
        }

        /* Uncomment to use ViewBag for registration
        public ActionResult Registration(string name, string age, string gender, string email,
                                        string telephone, string notification, string password,
                                        string remember)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Gender = gender;
            ViewBag.Email = email;
            ViewBag.Telephone = telephone;
            ViewBag.Notification = notification;
            ViewBag.Password = password;
            ViewBag.Remember = remember;
            return View();
        }*/

        // Registration via Model
        public ActionResult Registration(Account account)
        {
            account.Date = DateTime.UtcNow;
            AccountDb.Create(account);
            return View(account);
        }

        //Home page
        public ActionResult HomePage()
        {
            if (!voted)
            {
                ViewBag.Question = QuestionDb.Find(1);
            }
            else
            {
                ViewBag.Result = Question.TotalAnswers;
            }
            TagDb.GetAll();
            return View(PostDb.GetAll());
        }

        //Guest Page
        public ActionResult GuestPage()
        {
            return View(ReviewDb.GetAll());
        }

        //Comment add at GuestPage
        [HttpPost]
        public ActionResult LeaveComment(Review review)
        {
            //Should we write down the properties in other class?
            review.Date = DateTime.UtcNow;
            ReviewDb.Create(review);
            return View("GuestPage", ReviewDb.GetAll());
        }

        //Add post at Home Page
        [HttpPost]
        public ActionResult CreatePost(Post post, string Tags)
        {
            post.Date = DateTime.UtcNow;

            List<string> list = Tags.Split(' ').ToList();
            foreach (string tag in list)
            {
                var newtag = TagDb.FindByText(Tags);
                if (newtag == null)
                {
                    newtag = new Tag();
                    newtag.Text = tag;
                    TagDb.Create(newtag);
                }
                post.Tags.Add(newtag);
            }
            PostDb.Create(post);
            return View("HomePage", PostDb.GetAll());
        }

        //Voting at HomePage
        [HttpGet]
        public ActionResult Vote(int id)
        {
            voted = true;
            QuestionDb.Vote();
            ViewBag.Result = Question.TotalAnswers;
            return View("HomePage", PostDb.GetAll());
        }

        [HttpGet]
        public ActionResult FullPost(int id)
        {
            return View(PostDb.Find(id));
        }
    }
}