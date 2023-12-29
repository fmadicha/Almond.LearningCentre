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
        [HttpGet]
        public IActionResult GetAll()
        {
            var studentList = new List<Student>() {
                new Student()
                {
                       Id = 1,
                ImageUrl = "student.jpg",
                FirstName = "Farirai",
                Surname = " Darikwa",
                Grade = Models.Enum.Grades.GradeOne,
                DateOfBirth =DateTime.Now,
                GuardianName = "Mary Darikwa",
                GuardianAddress = "11 Las Vegas Cresc Cosmo Cit 2188",
                GuardianPhoneNumber = "071 868 3001",
                GuardianEmail = "darikwaf@gmail.com",
                Allergies = " Non",
                IsDeleted =  true
                }
                };
            return Json(new { data = studentList });
        }

        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int studentId)
        {
            var model = new Student()
            {
                Id = 1,
                ImageUrl = "hhhgkjl",
                FirstName = "Farirai",
                Surname = " Darikwa",
                Grade = Models.Enum.Grades.GradeOne,
                DateOfBirth = DateTime.Now,
                GuardianName = "Mary Darikwa",
                GuardianAddress = "11 Las Vegas Cresc Cosmo Cit 2188",
                GuardianPhoneNumber = "071 868 3001",
                GuardianEmail = "darikwaf@gmail.com",
                Allergies = " Non",
                IsDeleted = true,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Upsert(Student student)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            return View();
        }


    }
}
