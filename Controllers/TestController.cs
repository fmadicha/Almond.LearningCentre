using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Almond.LearningCentre.Models.ViewModel;
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
        public IActionResult Upsert(int testId)
        {
            if (testId == 0)
            {
                var model = new TestVM()
                {
                    CreatedBy = "System",                 
                    LastModifiedBy = "System"                                  
                };
                return View(model);
            }
            else
            {
                var model = unitOfWork.TestRepository.GetTest(testId);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Upsert(TestVM test)
        {
            if (ModelState.IsValid)
            {
                if (test.Id == 0)
                {
                    unitOfWork.TestRepository.AddTests(GetTest(test));
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.TestRepository.UpdateTests(GetTest(test));
                }
                return RedirectToAction("Index");
            }
            
            return View(test);
        }
        private Test GetTest(TestVM test)
        {
            return new Test ()
            {
                IsDeleted = test.IsDeleted,
                Id=test.Id,
                Description=test.Description,
                CreatedBy =  test.CreatedBy,
                DateCreated = test.DateCreated,
                IsEncrypted = test.IsEncrypted,
                LastModifiedBy = test.LastModifiedBy,
                LastModifiedDate = test.LastModifiedDate,
                PdfFile = new byte[1],
            
                SubjectId = test.SubjectId,
                Term = test.Term,
                TotalMark = test.TotalMark,
                Weight = test.Weight
            };
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult DeleteTest(int id)
        {
            return View();
        }

    }
}
