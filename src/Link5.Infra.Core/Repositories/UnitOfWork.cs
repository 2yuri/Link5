using System;
using System.Threading.Tasks;
using Link5.Infra.Core.Context;
using Link5.Infra.Core.Interfaces;

namespace AgentBuddy.Infra.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public DataContext GetContext()
        {
            return _context;
        }

        public void Rollback()
        {

        }
    }
}
