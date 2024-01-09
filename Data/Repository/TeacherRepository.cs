using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AlmondDbContext context;

        public TeacherRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return context.Teachers;
        }
        public Teacher GetTeacher(int id)
        {
            return context.Teachers.Single(x => x.Id == id);
        }
        public Teacher AddTeachers(Teacher teacher)
        {
            context.AddAsync(teacher);
            return teacher;
        }
        public void UpdateTeachers(Teacher teacher)
        {
            context.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteTeacher(Teacher teacher)
        {
            teacher.IsDeleted = true;
            context.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
