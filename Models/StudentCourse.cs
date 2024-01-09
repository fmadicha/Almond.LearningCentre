namespace Almond.LearningCentre.Models
{
    public partial class StudentCourse: AbstractEntity
    {      
        public string Description { get; set; } = null!;
        public int CourseId { get; set; }
        public int StudentId { get; set; }
     
        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
