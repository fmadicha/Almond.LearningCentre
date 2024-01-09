using Almond.LearningCentre.Data.Repository;

namespace Almond.LearningCentre.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IAssessmentRepository AssessmentRepository { get; }
        ICourseRepository CourseRepository { get; }
        ICourseSubjectRepository CourseSubjectRepository { get; }
        IStudentCoursesRepository StudentCoursesRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ITestRepository TestRepository { get; }
        void Dispose();
        Task Save();
    } 
}