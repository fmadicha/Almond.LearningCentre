using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Test : AbstractEntity
    {
   
        public string Description { get; set; }
        public int TotalMark { get; set; }
        public SchoolTerms Term { get; set; }
        public Double Weight { get; set; }
        public byte[] PdfFile { get; set; }
        public int SubjectId { get; set; }
    }
}
