using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class TeacherController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var teacherList = new List<Teacher>() {
                new Teacher()
                {
                Id = 1,
                ImageUrl = "Teacher.jpg",
                FirstName = "Farirai",
                Surname = " Darikwa",
                DateOfBirth =DateTime.Now,
                HomeAddress = "11 Las Vegas Cresc Cosmo Cit 2188",
                PhoneNumber = "071 868 3001",
                Email = "darikwaf@gmail.com",
                HealthyProblems = " Non"
             
                }
                };
            return Json(new { data = teacherList });
        }

        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int teacherId)
        {
            var model = new Teacher()
            {
                Id = 1,
                ImageUrl = "Teacher.jpg",
                FirstName = "Farirai",
                Surname = " Darikwa",
                DateOfBirth = DateTime.Now,
                HomeAddress = "11 Las Vegas Cresc Cosmo Cit 2188",
                PhoneNumber = "071 868 3001",
                Email = "darikwaf@gmail.com",
                HealthyProblems = " Non"
               
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
