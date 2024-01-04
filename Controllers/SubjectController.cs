using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class SubjectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var subjectList = new List<Subject>() {
                new Subject()
                {
                Id = 1,
                Description= "Grade One ",
                 TeacherId = 001,
                }
                };
            return Json(new { data = subjectList });
        }

        [HttpGet]
        public IActionResult GetSubject(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int subjectId)
        {
            var model = new Subject()
            {
                Id = 1,
                Description = "Grade one",
               TeacherId = 001,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Upsert(Subject subject)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteSubject(int id)
        {
            return View();
        }

    }
}
