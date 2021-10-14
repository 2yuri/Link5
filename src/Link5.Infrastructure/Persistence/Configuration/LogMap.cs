using System;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Link5.Infrastructure.Persistence.Configuration
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasOne(t => t.Link).WithMany(t => t.Logs);
        }
    }
}
