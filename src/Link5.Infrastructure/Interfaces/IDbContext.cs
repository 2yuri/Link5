using System;
namespace Link5.Infrastructure.Interfaces
{
    public interface IDbContext
    {
        void Begin();
        void Commit();
        void Rollback();
    }
}
