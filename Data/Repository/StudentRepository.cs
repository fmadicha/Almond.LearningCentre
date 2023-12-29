﻿using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AlmondDbContext context;

        public StudentRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Student> GetAllStudents()
        {
            return context.Students;
        }
        public Student GetStudent(int id)
        {
            return context.Students.Single(x => x.Id == id);
        }
        public Student AddStudents(Student student)
        {
            context.AddAsync(student);
            return student;
        }
        public void UpdateStudents(Student student)
        {
            context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteStudent(Student student)
        {
            student.IsDeleted = true;
            context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}

  
