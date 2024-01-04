﻿namespace Almond.LearningCentre.Models
{
    public class CourseSubject: AbstractEntity
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
        public virtual Course Course { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
