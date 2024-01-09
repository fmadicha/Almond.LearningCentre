namespace Almond.LearningCentre.Models
{
    public partial class CourseSubject: AbstractEntity
    {     
        public string Description { get; set; } = null!;
        public int CourseId { get; set; }
        public int SubjectId { get; set; }   

        public virtual Course Course { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
