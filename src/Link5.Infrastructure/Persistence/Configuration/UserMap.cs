using System;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Link5.Infrastructure.Persistence.Configuration
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(t => t.Links).WithOne(t => t.User);
            builder.HasOne(t => t.Layout).WithOne(t => t.User);
            builder.HasMany(t => t.Hashes).WithOne(t => t.User);
        }
    }
}
