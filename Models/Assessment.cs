using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Assessment: AbstractEntity
    {
        
        public string Description { get; set; }
        public int StudentId { get; set; }
        public int TestId { get; set; }
        public Decimal Mark { get; set; }
        public string DateOfAssessment { get; set; }
        public SchoolTerms Term { get; set; }
        public int TeacherId { get; set; }
    }
}
