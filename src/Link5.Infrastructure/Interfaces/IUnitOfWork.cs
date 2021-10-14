using Link5.Infrastructure.Common;

namespace Link5.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        DataContext GetInstance();
    }
}
