using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ITestRepository
    {
        Test AddTests(Test test);
        void DeleteTest(Test test);
        IQueryable<Test> GetAllTests();
        Test GetStudent(int id);
        void UpdateTests(Test test);
    }
}