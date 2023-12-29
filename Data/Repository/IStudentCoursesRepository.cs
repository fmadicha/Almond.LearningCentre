using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface IStudentCoursesRepository
    {
        StudentCourses AddStudentCourses(StudentCourses studentCourses);
        void DeleteStudentCourses(StudentCourses studentCourses);
        IQueryable<StudentCourses> GetAllStudentCourses();
        StudentCourses GetStudentCourses(int id);
        void UpdateStudentCourses(StudentCourses studentCourses);
    }
}