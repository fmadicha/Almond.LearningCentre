using Almond.LearningCentre.Data.Repository;

namespace Almond.LearningCentre.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }

        void Dispose();
        Task Save();
    }
}