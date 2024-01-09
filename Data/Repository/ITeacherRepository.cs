using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ITeacherRepository
    {
        Teacher AddTeachers(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
        void UpdateTeachers(Teacher teacher);
    }
}