using Almond.LearningCentre.Data.UnitOfWork;
using Almond.LearningCentre.Models;
using Almond.LearningCentre.Models.ViewModel;
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

        
       private Subject GetSubject(SubjectVM subject)
        {
            
            return new Subject()
            {

                IsDeleted = subject.IsDeleted,
                Id = subject.Id,
                Description = subject.Description,
                CreatedBy = subject.CreatedBy,
                DateCreated = subject.DateCreated,
                IsEncrypted = subject.IsEncrypted,
                LastModifiedBy = subject.LastModifiedBy,
                LastModifiedDate = subject.LastModifiedDate,
                TeacherId = subject.TeacherId
                
            };
            throw new NotImplementedException();
        }
        
      
        [HttpGet]
        public IActionResult Upsert(int subjectId)
        {
            
            
                if (subjectId == 0)
                {
                    var model = new StudentVM()
                    {
                        CreatedBy = "System",
                        LastModifiedBy = "System"
                    };
                    return View(model);
                }
                else
                {
                    var model = unitOfWork.SubjectRepository.GetSubject(subjectId);
                    return View(model);
                }
        }

        [HttpPost]
        public IActionResult Upsert(SubjectVM subject)
        {
            if (ModelState.IsValid)
            {
                if (subject.Id == 0)
                {
                    unitOfWork.SubjectRepository.AddSubjects(GetSubject(subject));
                    unitOfWork.Save();
                }
                else
                {
                    unitOfWork.SubjectRepository.UpdateSubjects(GetSubject(subject));
                }
                return RedirectToAction("Index");
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
