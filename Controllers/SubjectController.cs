using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Controllers
{
    
    public class SubjectController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SubjectController(IUnitOfWork unitOfWork)
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
            var subjectList = unitOfWork.SubjectRepository.GetAllSubjects();
            return Json(new { data = subjectList });
        }

        [HttpGet]
        public IActionResult GetSubject(int id)
        {
            var subject = unitOfWork.SubjectRepository.GetSubject(id);
            return Json(new { data = subject });
        }

        [HttpGet]
        public IActionResult Upsert(Subject subject)
        {
            if(ModelState.IsValid)
            {
                if (subject.Id == 0)
                {
                    unitOfWork.SubjectRepository.AddSubjects(subject);
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.SubjectRepository.UpdateSubjects(subject);
                }
                return View(Index);
            }
            
            return View(subject);
        }

       

        [HttpPost]
        public IActionResult DeleteSubject(int id)
        {
            return View();
        }

    }
}
