using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AlmondDbContext context;

        public CourseRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Course> GetAllCourses()
        {
            return context.Courses;
        }
        public Course GetCourses(int id)
        {
            return context.Courses.Single(x => x.Id == id);
        }
        public Course AddCourses(Course course)
        {
            context.AddAsync(course);
            return course;
        }
        public void UpdateCourses(Course course)
        {
            context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteCaurses(Course course)
        {
            course.IsDeleted = true;
            context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
