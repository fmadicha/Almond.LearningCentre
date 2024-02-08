namespace Almond.LearningCentre.Models.ViewModel
{
    public class CourseVM: AbstractEntity
    {

        public string Description { get; set; } = null!;
        public int SubjectId { get; set; }
    }
}
