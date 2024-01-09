using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class CourseController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CourseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var courseList = unitOfWork.CourseRepository.GetAllCourses();
            return Json(new { data = courseList});
        }

        [HttpGet]
        public IActionResult GetCourse(int id)
        {
            var course = unitOfWork.CourseRepository.GetCourses(id);
            return Json(new { data = course });
        }

        [HttpGet]
        public IActionResult Upsert(Course course)
        {
            if (ModelState.IsValid)
            {
                if (course.Id == 0)
                {
                    unitOfWork.CourseRepository.AddCourses(course);
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.CourseRepository.UpdateCourses(course);
                }
                return View(Index);
            }
            return View(course);
        }

        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            return View();
        }

    }
}
