using Almond.LearningCentre.Models;
using Microsoft.EntityFrameworkCore;

namespace Almond.LearningCentre.Data
{
    public class AlmondDbContext:DbContext
    {

        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
    }
}
