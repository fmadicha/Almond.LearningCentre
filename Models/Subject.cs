namespace Almond.LearningCentre.Models
{
    public partial class Subject: AbstractEntity
    {
        public Subject()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            Tests = new HashSet<Test>();
        }

        public string Description { get; set; } = null!;
        public int TeacherId { get; set; }


        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
