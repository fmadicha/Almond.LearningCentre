namespace Almond.LearningCentre.Models
{
    public abstract class AbstractEntity
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEncrypted { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
