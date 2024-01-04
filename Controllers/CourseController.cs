using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class CourseController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var courseList = new List<Course>() {
                new Course()
                {
                Id = 1,
                Description= "Grade One ",
                 SubjectId = 01,
                }
                };
            return Json(new { data = courseList});
        }

        [HttpGet]
        public IActionResult GetCourse(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int courseId)
        {
            var model = new Course()
            {
                Id = 1,
                Description = "Grade one",
                SubjectId = 01,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Upsert(Course course)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            return View();
        }

    }
}
