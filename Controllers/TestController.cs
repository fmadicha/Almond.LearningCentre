using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    public class TestController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
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
            var testList = unitOfWork.TestRepository.GetAllTests();
            return Json(new { data=testList });
        }

        [HttpGet]
        public IActionResult GetTest(int id)
        {
            var test = unitOfWork.TestRepository.GetTest(id);
            return Json(new { data = test });
        }

        [HttpGet]
        public IActionResult Upsert(Test test)
        {
            if (ModelState.IsValid)
            {
                if (test.Id == 0)
                {
                    unitOfWork.TestRepository.AddTests(test);
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.TestRepository.UpdateTests(test);
                }
                return View(Index);
            }
            
            return View(test);
        }

        [HttpPost]
        public IActionResult DeleteTest(int id)
        {
            return View();
        }

    }
}
