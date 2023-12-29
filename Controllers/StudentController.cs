using Microsoft.AspNetCore.Mvc;
using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult GetStudent(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult UpdateStudent(Student student)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult DeleteStudent(int id)
        //{
        //    return View();
        //}

        //[HttpPut]
        //public IActionResult CreateStudent(Student student)
        //{
        //    return View();
        //}
    }
}
