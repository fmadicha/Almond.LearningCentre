using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var testList = new List<Test>() {
                new Test()
                {
                Id = 1,
                Description= "Maths Paper 1 Test",
                TotalMark = 50,
                Term = Models.Enum.SchoolTerms.TermOne,
                Weight = 0.25m,
                PdfFile =  new byte[1], 
                SubjectId = 01,
               

                }
                };
            return Json(new { data = testList });
        }

        [HttpGet]
        public IActionResult GetTest(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int testId)
        {
            var model = new Test()
            {
                Id = 1,
                Description = "Maths Paper 1 Test",
                TotalMark = 50,
                Term = Models.Enum.SchoolTerms.TermOne,
                Weight = 0.25m,
                PdfFile = new byte[1], 
                SubjectId = 01,


            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Upsert(Test test)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTest(int id)
        {
            return View();
        }

    }
}
