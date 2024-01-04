namespace Almond.LearningCentre.Models
{
    public class Course: AbstractEntity
    {
        public Course()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}

