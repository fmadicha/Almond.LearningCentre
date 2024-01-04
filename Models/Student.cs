using Almond.LearningCentre.Models.Enum;

namespace Almond.LearningCentre.Models
{
    public class Student: AbstractEntity
    {
        public Student()
        {
            Assessments = new HashSet<Assessment>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public Grades Grade { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GuardianName { get; set; } = null!;
        public string GuardianAddress { get; set; } = null!;
        public string GuardianPhoneNumber { get; set; } = null!;
        public string GuardianEmail { get; set; } = null!;
        public string Allergies { get; set; } = null!;
    

        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}