using Almond.LearningCentre.Data.Repository;

namespace Almond.LearningCentre.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AlmondDbContext _context;


        public UnitOfWork(AlmondDbContext context,
            IStudentRepository studentRepository,
            IAssessmentRepository assessmentRepository,
            ICourseRepository courseRepository,
           ICourseSubjectRepository courseSubjectRepository,
           IStudentCoursesRepository studentCoursesRepository,
           ISubjectRepository subjectRepository,
           ITeacherRepository teacherRepository,
           ITestRepository testRepository)
        {
            _context = context;
            StudentRepository = studentRepository;
            AssessmentRepository = assessmentRepository;
            CourseRepository = courseRepository;
            CourseSubjectRepository = courseSubjectRepository;
            StudentCoursesRepository = studentCoursesRepository;
            SubjectRepository = subjectRepository;
            TeacherRepository = teacherRepository;
            TestRepository = testRepository;
        }

        public IStudentRepository StudentRepository { get; }
        public IAssessmentRepository AssessmentRepository { get; }
        public ICourseRepository CourseRepository { get; }
        public ICourseSubjectRepository CourseSubjectRepository { get; }
        public IStudentCoursesRepository StudentCoursesRepository { get; }
        public ISubjectRepository SubjectRepository { get; }
        public ITeacherRepository TeacherRepository { get; }
        public ITestRepository TestRepository { get; }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()        {

            await _context.SaveChangesAsync();
        }
    }
}