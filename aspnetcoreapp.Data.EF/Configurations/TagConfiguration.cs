using aspnetcoreapp.Data.EF.Extensions;
using aspnetcoreapp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcoreapp.Data.EF.Configurations
{
    class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
