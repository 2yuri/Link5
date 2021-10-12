using System;
using System.Threading.Tasks;
using Link5.Infra.Core.Context;

namespace Link5.Infra.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
        void Rollback();
        DataContext GetContext();
    }
}
