using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewQuestions.Models;

namespace InterviewQuestions.Controllers
{

    public class HomeController : Controller
    {
        CompanyDB companyDB = new CompanyDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SQL()
        {
            //CompanyDB companyDB = new CompanyDB();
            var query = from quest in companyDB.questions
                        where quest.Type == "SQL"
                        select quest;
            //var Sql = companyDB.questions.ToList();


            return View(query);
        }

        public ActionResult React()
        {
            var query = from quest in companyDB.questions
                        where quest.Type == "React"
                        select quest;
            return View(query);
        }

        public ActionResult Angular()
        {
            var query = from quest in companyDB.questions
                        where quest.Type == "Angular"
                        select quest;
            return View(query);
        }

    }
}