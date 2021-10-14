using System;
using Link5.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Link5.Infrastructure.Persistence.Configuration
{
    public class LayoutMap : IEntityTypeConfiguration<Layout>
    {
        public void Configure(EntityTypeBuilder<Layout> builder)
        {
            builder.HasOne(t => t.User).WithOne(t => t.Layout);
        }
    }
}
