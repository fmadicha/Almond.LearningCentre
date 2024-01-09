using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
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
            var teacherList = unitOfWork.TeacherRepository.GetAllTeachers();
            return Json(new { data = teacherList });
        }

        [HttpGet]
        public IActionResult GetTeacher(int id)
        {
            var teacher = unitOfWork.TeacherRepository.GetTeacher(id);
            return Json(new {data=teacher});
        }

        [HttpGet]
        public IActionResult Upsert(Teacher teacher)
        {
           if(ModelState.IsValid)
            {
                if (teacher.Id == 0)
                {
                    unitOfWork.TeacherRepository.AddTeachers(teacher);
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.TeacherRepository.UpdateTeachers(teacher);
                }
                return View(Index);
            }
            return View(teacher);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            return View();
        }

    }
}
