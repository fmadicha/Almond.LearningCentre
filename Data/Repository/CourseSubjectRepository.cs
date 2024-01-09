using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class CourseSubjectRepository : ICourseSubjectRepository
    {
        private readonly AlmondDbContext context;

        public CourseSubjectRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<CourseSubject> GetAllCourseSubjects()
        {
            return context.CourseSubjects;
        }
        public CourseSubject GetCourseSubject(int id)
        {
            return context.CourseSubjects.Single(x => x.Id == id);
        }
        public CourseSubject AddCourseSubjects(CourseSubject courseSubject)
        {
            context.AddAsync(courseSubject);
            return courseSubject;
        }
        public void UpdateCourseSubjects(CourseSubject courseSubject)
        {
            context.Entry(courseSubject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteCourseSubject(CourseSubject courseSubject)
        {
            courseSubject.IsDeleted = true;
            context.Entry(courseSubject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
