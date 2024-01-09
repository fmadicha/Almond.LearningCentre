using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface IStudentRepository
    {
        Student AddStudents(Student student);
        void DeleteStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        void UpdateStudents(Student student);
    }
}