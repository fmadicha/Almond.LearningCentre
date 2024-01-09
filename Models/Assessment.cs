using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Assessment: AbstractEntity
    {   
        public string Description { get; set; } = null!;
        public int StudentId { get; set; }
        public int TestId { get; set; }
        public decimal Mark { get; set; }
        public string DateOfAssessment { get; set; } = null!;
        public int Term { get; set; }
        public int TeacherId { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
