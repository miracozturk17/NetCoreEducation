using Microsoft.AspNetCore.Mvc;
using System;
using NetCoreEducation.Model;
using System.Linq;
using NetCoreEducation.ViewModels;
using System.Collections.Generic;

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

            var categories = new List<Category>()
            {
                new Category(){CategoryId = 1,CategoryName = "Matematik"},
                new Category(){CategoryId = 2,CategoryName = "Fizik"}
            };

            var course = new Course()
            {
                CourseId = 1,
                Name = "Matematik",
                CreateDate = DateTime.Now,
                Description = "Matematiksel Algoritmalar",
                IsPublish = true,
                PublishDate = DateTime.Now,
                TeacherId = 1
            };

            var student = new Student()
            {
                Name = "Miraç",
                SurName = "ÖZTÜRK",
                Confirm = true,
                Phone = "0444444444",
                Email = "m@gmail.com"
            };

            var viewModel = new CourseStudentViewModel();
            viewModel.Courses = course;
            viewModel.Students = student;
            viewModel.Categories = categories;
            // ACTION METHOD OBEKLERI.
            return View(viewModel);
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