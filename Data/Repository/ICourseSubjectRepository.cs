using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ICourseSubjectRepository
    {
        CourseSubject AddCourseSubjects(CourseSubject courseSubject);
        void DeleteCourseSubject(CourseSubject courseSubject);
        IQueryable<CourseSubject> GetAllCourseSubjects();
        CourseSubject GetCourseSubject(int id);
        void UpdateCourseSubjects(CourseSubject courseSubject);
    }
}