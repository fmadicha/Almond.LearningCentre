using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly AlmondDbContext context;

        public TestRepository(AlmondDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Test> GetAllTests()
        {
            return context.Tests;
        }
        public Test GetStudent(int id)
        {
            return context.Tests.Single(x => x.Id == id);
        }
        public Test AddTests(Test test)
        {
            context.AddAsync(test);
            return test;
        }
        public void UpdateTests(Test test)
        {
            context.Entry(test).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void DeleteTest(Test test)
        {
            test.IsDeleted = true;
            context.Entry(test).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
