using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public partial class Test: AbstractEntity
    {  
        public string Description { get; set; } = null!;
        public int TotalMark { get; set; }
        public int Term { get; set; }
        public decimal Weight { get; set; }
        public byte[] PdfFile { get; set; } = null!;
        public int SubjectId { get; set; }     
        public virtual Subject Subject { get; set; } = null!;
    }
}
