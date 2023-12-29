namespace Almond.LearningCentre.Models
{
    public class CourseSubject: AbstractEntity
    {
        
        public string Description { get; set; }
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
    }
}
