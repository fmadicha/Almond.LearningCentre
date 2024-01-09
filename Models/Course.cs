namespace Almond.LearningCentre.Models
{
    public partial class Course: AbstractEntity
    {  
            public Course()
            {
                CourseSubjects = new HashSet<CourseSubject>();
                StudentCourses = new HashSet<StudentCourse>();
            }

            public string Description { get; set; } = null!;
            public int SubjectId { get; set; }
           
            public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
            public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        }
    }
