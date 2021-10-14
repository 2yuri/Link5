using System;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Link5.Infrastructure.Persistence.Configuration
{
    public class HashMap : IEntityTypeConfiguration<Hash>
    {
        public void Configure(EntityTypeBuilder<Hash> builder)
        {
            builder.HasOne(t => t.User).WithMany(t => t.Hashes);
        }
    }
}
