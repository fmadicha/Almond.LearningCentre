﻿using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface IStudentCoursesRepository
    {
        StudentCourse AddStudentCourses(StudentCourse studentCourses);
        void DeleteStudentCourses(StudentCourse studentCourses);
        IEnumerable<StudentCourse> GetAllStudentCourses();
        StudentCourse GetStudentCourses(int id);
        void UpdateStudentCourses(StudentCourse studentCourses);
    }
}