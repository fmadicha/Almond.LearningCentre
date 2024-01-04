using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Test : AbstractEntity
    {
        public Test()
        {
            Assessments = new HashSet<Assessment>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int TotalMark { get; set; }
        public SchoolTerms Term { get; set; }
        public decimal Weight { get; set; }
        public byte[] PdfFile { get; set; } = null!;
        public int SubjectId { get; set; }
        
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
