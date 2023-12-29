using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AlmondDbContext context;

        public SubjectRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Subject> GetAllSubjects()
        {
            return context.Subjects;
        }
        public Subject GetSubject(int id)
        {
            return context.Subjects.Single(x => x.Id == id);
        }
        public Subject AddSubjects(Subject subject)
        {
            context.AddAsync(subject);
            return subject;
        }
        public void UpdateSubjects(Subject subject)
        {
            context.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteSubject(Subject subject)
        {
            subject.IsDeleted = true;
            context.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
