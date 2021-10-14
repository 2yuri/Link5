using System;
using System.Reflection;
using Link5.Infrastructure.Interfaces;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Link5.Infrastructure.Common
{
    public class DataContext : DbContext, IDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Hash> Hashes { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Layout> Layouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        private IDbContextTransaction DbCtx { get; set; }

        public void Begin()
        {
            Database.BeginTransaction();
        }

        public void Commit()
        {
            SaveChanges();
            DbCtx.Commit();
        }

        public void Rollback()
        {
            DbCtx.Rollback();
        }
    }
}
