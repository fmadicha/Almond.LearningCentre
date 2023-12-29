using Almond.LearningCentre.Data;
using Almond.LearningCentre.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almond.LearningCentre.Services
{
    public class StudentServices
    {
        private readonly AlmondDbContext context;
        public StudentServices(AlmondDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public IQueryable<Student> GetAllStudents()
        {
            return context.Students;
        }
        [HttpGet]
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




