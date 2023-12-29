namespace Almond.LearningCentre.Models
{
    public class StudentCourses: AbstractEntity
    {
        
        public string Description { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
