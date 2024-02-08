using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Almond.LearningCentre.Models.ViewModel;
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

       
        public Teacher GetTeacher(TeacherVM teacher)
        {

            return new Teacher()
            {
                IsDeleted = teacher.IsDeleted,
                Id = teacher.Id,
                CreatedBy = teacher.CreatedBy,
                DateCreated = teacher.DateCreated,
                IsEncrypted = teacher.IsEncrypted,
                LastModifiedBy = teacher.LastModifiedBy,
                LastModifiedDate = teacher.LastModifiedDate,
                FirstName = teacher.FirstName,
                Surname = teacher.Surname,
                DateOfBirth = teacher.DateOfBirth,
                HomeAddress= teacher.HomeAddress,
               PhoneNumber = teacher.PhoneNumber,
                Email = teacher.Email,
                ImageUrl="Test.jpg",
                HealthyProblems= teacher.HealthyProblems
            };
            throw new NotImplementedException();
        }

            [HttpGet]
        public IActionResult Upsert(int teacherId)
        {
            if (teacherId == 0)
            {
                var model = new TeacherVM()
                {
                    CreatedBy = "System",
                    ImageUrl = "Test",
                    LastModifiedBy = "System"
                };

                return View(model);
            }
            else
            {
                var model = unitOfWork.TeacherRepository.GetTeacher(teacherId);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Upsert(TeacherVM teacherVm)
        {
           if(ModelState.IsValid)
            {
                if (teacherVm.Id == 0)
                {
                    unitOfWork.TeacherRepository.AddTeachers(GetTeacher(teacherVm));
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.TeacherRepository.UpdateTeachers(GetTeacher(teacherVm));
                }
                return RedirectToAction("Index");
            }
            return View(teacherVm);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            return View();
        }

    }
}
