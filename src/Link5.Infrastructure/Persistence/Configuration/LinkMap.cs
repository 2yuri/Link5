using System;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Link5.Infrastructure.Persistence.Configuration
{
    public class LinkMap : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasMany(t => t.Logs).WithOne(t => t.Link);
            builder.HasOne(t => t.User).WithMany(t => t.Links);
        }
    }
}
