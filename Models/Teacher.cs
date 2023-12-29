namespace Almond.LearningCentre.Models
{
    public class Teacher: AbstractEntity
    {

       
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HealthyProblems { get; set; }
    }
}
