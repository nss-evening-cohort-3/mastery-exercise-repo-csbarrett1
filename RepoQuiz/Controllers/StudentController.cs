using RepoQuiz.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentRepository myRepo = new StudentRepository();
            ViewBag.Students = myRepo.GetAllStudents();
            return View();
        }
    }
}
