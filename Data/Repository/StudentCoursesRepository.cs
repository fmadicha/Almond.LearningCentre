using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class StudentCoursesRepository : IStudentCoursesRepository
    {
        private readonly AlmondDbContext context;

        public StudentCoursesRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<StudentCourses> GetAllStudentCourses()
        {
            return context.StudentCourses;
        }
        public StudentCourses GetStudentCourses(int id)
        {
            return context.StudentCourses.Single(x => x.Id == id);
        }
        public StudentCourses AddStudentCourses(StudentCourses studentCourses)
        {
            context.AddAsync(studentCourses);
            return studentCourses;
        }
        public void UpdateStudentCourses(StudentCourses studentCourses)
        {
            context.Entry(studentCourses).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteStudentCourses(StudentCourses studentCourses)
        {
            studentCourses.IsDeleted = true;
            context.Entry(studentCourses).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
