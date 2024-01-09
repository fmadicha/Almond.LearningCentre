using Almond.LearningCentre.Models;

namespace Almond.LearningCentre.Data.Repository
{
    public interface ITestRepository
    {
        Test AddTests(Test test);
        void DeleteTest(Test test);
        IEnumerable<Test> GetAllTests();
        Test GetTest(int id);
        void UpdateTests(Test test);
    }
}