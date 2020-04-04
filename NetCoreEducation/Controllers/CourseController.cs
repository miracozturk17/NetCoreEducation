using Microsoft.AspNetCore.Mvc;
using System;

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

        public IActionResult Apply()
        {
            //return "Course/Apply";
            return View();
        }

        // HAKKINDA SAYFASI.
        public IActionResult About()
        {
            //return "Course/Index";
            return View();
        }

        // COURSE LISTE SAYFASI.
        public IActionResult List()
        {
            // return "Course/Index";
            return View();
        }

        /// <summary>
        /// BILGILER : NAME - DESCRIPTION - ISPUBLISH - PUBLISHDATE - TEACHER 
        /// </summary>
        /// <returns></returns>
        // COURSE DETAY SAYFASI.
        public IActionResult Details()
        {
            //return "Course/Details";
            return View();
        }
    }
}