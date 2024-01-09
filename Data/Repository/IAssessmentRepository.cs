using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface IAssessmentRepository
    {
        Assessment AddAssessments(Assessment assessment);
        void DeleteAssessment(Assessment assessment);
        IEnumerable<Assessment> GetAllAssessments();
        Assessment GetAssessment(int id);
        void UpdateAssessments(Assessment assessment);
    }
}