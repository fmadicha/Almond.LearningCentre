using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ISubjectRepository
    {
        Subject AddSubjects(Subject subject);
        void DeleteSubject(Subject subject);
        IQueryable<Subject> GetAllSubjects();
        Subject GetSubject(int id);
        void UpdateSubjects(Subject subject);
    }
}