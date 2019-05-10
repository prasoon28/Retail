using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            Student s1 = new Student { Studid = 23, Name = "Parag", Sem = 1 };
            List<Student> l1 = new List<Student>();
            l1.Add(s1);
            return View(l1);
        }
    }
}