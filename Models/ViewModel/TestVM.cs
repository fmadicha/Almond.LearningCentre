namespace Almond.LearningCentre.Models.ViewModel
{
    public class TestVM: AbstractEntity
    {
        public string Description { get; set; } = null!;
        public int TotalMark { get; set; }
        public int Term { get; set; }
        public decimal Weight { get; set; }
      //  public byte[] PdfFile { get; set; } = null!;
        public int SubjectId { get; set; }
      
    }
}
