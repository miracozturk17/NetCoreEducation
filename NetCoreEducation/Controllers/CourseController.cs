using Microsoft.AspNetCore.Mvc;
using System;
using NetCoreEducation.Model;
using System.Linq;

namespace NetCoreEducation.Controllers
{
    public class CourseController : Controller
    {
        /*
         http://localhost:63390/Course/Index
         http://localhost:63390/Course/IndexTest
        */
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "Iyı Gunler" : "Gunaydın";
            ViewBag.UserName = "Mırac";

            // ACTION METHOD OBEKLERI.
            return View();
        }

        public IActionResult ByReleased(int year, int month)
        {
            //return "Course/ByReleased";
            return Content("year:" + year, " month:" + month);
        }

        public IActionResult Apply()
        {
            //return "Course/Apply";
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            //return "Course/Apply";
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            return View(student);
        }

        // HAKKINDA SAYFASI.
        public IActionResult About()
        {
            //return "Course/Index";
            return Redirect("www.miracozturk.com");
        }

        // COURSE LISTE SAYFASI.
        public IActionResult List()
        {
            // return "Course/Index";

            return View();
        }

        // BILGILER : NAME - DESCRIPTION - ISPUBLISH - PUBLISHDATE - TEACHER 
        // COURSE DETAY SAYFASI.
        public IActionResult Details()
        {
            //return "Course/Details";
            var students = Repository.Students.Where(s => s.Confirm == true);
            return View(students);
        }
    }
}