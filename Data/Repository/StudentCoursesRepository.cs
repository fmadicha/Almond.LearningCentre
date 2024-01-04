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

        public IQueryable<StudentCourse> GetAllStudentCourses()
        {
            return context.StudentCourses;
        }
        public StudentCourse GetStudentCourses(int id)
        {
            return context.StudentCourses.Single(x => x.Id == id);
        }
        public StudentCourse AddStudentCourses(StudentCourse studentCourses)
        {
            context.AddAsync(studentCourses);
            return studentCourses;
        }
        public void UpdateStudentCourses(StudentCourse studentCourses)
        {
            context.Entry(studentCourses).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteStudentCourses(StudentCourse studentCourses)
        {
            studentCourses.IsDeleted = true;
            context.Entry(studentCourses).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
