namespace Almond.LearningCentre.Models
{
    public class Teacher: AbstractEntity
    {
        public Teacher()
        {
            Assessments = new HashSet<Assessment>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string HealthyProblems { get; set; } = null!;

        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
