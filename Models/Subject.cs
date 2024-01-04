namespace Almond.LearningCentre.Models
{
    public class Subject: AbstractEntity
    {
        public Subject()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            Courses = new HashSet<Course>();
            Tests = new HashSet<Test>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int TeacherId { get; set; }
       
        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}

