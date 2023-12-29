using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Student: AbstractEntity
    {
        
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Grades Grade { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GuardianName { get; set; }
        public string GuardinAddress { get; set; }
        public string GuardianPhoneNumber{ get; set; }
        public string GuardianEmail { get; set; }
        public string Allegies { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
