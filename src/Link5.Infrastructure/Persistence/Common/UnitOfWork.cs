using System;
using System.Threading.Tasks;
using Link5.Infrastructure.Common;
using Link5.Infrastructure.Interfaces;

namespace AgentBuddy.Infrastructure.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public DataContext GetInstance()
        {
            return _context;
        }

        public void BeginTransaction()
        {
            _context.Begin();
        }

        public void Commit()
        {
            _context.Commit();
        }

        public void Rollback()
        {
            _context.Rollback();
        }
    }
}