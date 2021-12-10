using UnitOfWork_Repository.Services;

namespace UnitOfWork_Repository.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
