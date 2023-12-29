using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class AssessmentRepository : IAssessmentRepository
    {

        private readonly AlmondDbContext context;

        public AssessmentRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Assessment> GetAllAssessments()
        {
            return context.Assessments;
        }
        public Assessment GetAssessment(int id)
        {
            return context.Assessments.Single(x => x.Id == id);
        }
        public Assessment AddAssessments(Assessment assessment)
        {
            context.AddAsync(assessment);
            return assessment;
        }
        public void UpdateAssessments(Assessment assessment)
        {
            context.Entry(assessment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteAssessment(Assessment assessment)
        {
            assessment.IsDeleted = true;
            context.Entry(assessment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
