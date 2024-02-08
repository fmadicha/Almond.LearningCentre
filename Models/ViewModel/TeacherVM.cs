namespace Almond.LearningCentre.Models.ViewModel
{
    public class TeacherVM: AbstractEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string HealthyProblems { get; set; } = null!;
       
    }
}
