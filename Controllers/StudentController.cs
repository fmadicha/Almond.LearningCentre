using Microsoft.AspNetCore.Mvc;
using Almond.LearningCentre.Models;
using Almond.LearningCentre.Data.UnitOfWork;

namespace Almond.LearningCentre.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
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
            //var studentList = new List<Student>() {
            //    new Student()
            //    {
            //           Id = 1,
            //    ImageUrl = "student.jpg",
            //    FirstName = "Farirai",
            //    Surname = " Darikwa",
            //    Grade = Models.Enum.Grades.GradeOne,
            //    DateOfBirth =DateTime.Now,
            //    GuardianName = "Mary Darikwa",
            //    GuardianAddress = "11 Las Vegas Cresc Cosmo Cit 2188",
            //    GuardianPhoneNumber = "071 868 3001",
            //    GuardianEmail = "darikwaf@gmail.com",
            //    Allergies = " Non",
            //    IsDeleted =  true
            //    }
            //    };

            var studentList = unitOfWork.StudentRepository.GetAllStudents();
            return Json(new { data = studentList });
        }

        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            var student = unitOfWork.StudentRepository.GetStudent(id);
            return Json(new { data = student });
           
        }

        [HttpGet]
        public IActionResult Upsert(int studentId)
        {    
            if (studentId == 0)
            {
                var model = new Student();
                return View(model);
            }
            else
            {
                var model = unitOfWork.StudentRepository.GetStudent(studentId);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Student student)
        {

            if (ModelState.IsValid)
            {

                if (student.Id == 0)
                {
                    unitOfWork.StudentRepository.AddStudents(student);
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.StudentRepository.UpdateStudents(student);
                    unitOfWork.Save();
                }
                return View("Index");

            }
            return View(student);

        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            return View();
        }


    }
}
