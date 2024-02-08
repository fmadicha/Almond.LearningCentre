using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Almond.LearningCentre.Models.ViewModel;
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

       
        private Test GetCourse(CourseVM course)
        {
            return new Test()
            {
                IsDeleted = course.IsDeleted,
                Id = course.Id,
                Description = course.Description,
                CreatedBy = course.CreatedBy,
                DateCreated = course.DateCreated,
                IsEncrypted = course.IsEncrypted,
                LastModifiedBy = course.LastModifiedBy,
                LastModifiedDate = course.LastModifiedDate,
                SubjectId = course.SubjectId
                
            };
            throw new NotImplementedException();
        }
        [HttpGet]
        public IActionResult Upsert(int courseId)
        {
            if (courseId == 0)
            {
                var model = new CourseVM()
                {
                   
                    CreatedBy = "System",
                   
                    LastModifiedBy = "System"
                };
                return View(model);
            }
            else
            {
                var model = unitOfWork.CourseRepository.GetCourses(courseId);
                return View(model);
            }
        }

        [HttpPost]
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
                return RedirectToAction("Index"); //View(Index);
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
