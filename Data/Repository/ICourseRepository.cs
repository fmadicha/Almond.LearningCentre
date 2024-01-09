using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ICourseRepository
    {
        Course AddCourses(Course course);
        void DeleteCourses(Course course);
        IEnumerable<Course> GetAllCourses();
        Course GetCourses(int id);
        void UpdateCourses(Course course);
    }
}