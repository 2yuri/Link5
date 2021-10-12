using System;
using Link5.Infra.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Link5.Infra.Core.Context
{
    public class DataContext : DbContext
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

        }
    }
}
