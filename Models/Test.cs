using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Test : AbstractEntity
    {
   
        public string Description { get; set; }
        public string TotalMark { get; set; }
        public SchoolTerms Term { get; set; }
        public Decimal Weight { get; set; }
        public byte[] PdfFile { get; set; }
        public string SubjectId { get; set; }
    }
}
